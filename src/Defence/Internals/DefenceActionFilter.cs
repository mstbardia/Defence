using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Defence.Core;
using Defence.Core.Abstractions;
using Defence.Core.Handlers.Internals.Abstractions;

namespace Defence.Internals;

/// <summary>
/// heart of library which resolves defined validators depend on your
/// request's model type then validates their fields and returns their errors
/// if any violation happens.
/// </summary>
internal class DefenceActionFilter : ActionFilterAttribute
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IDefenceErrorHandler _defenceErrorHandler;

    public DefenceActionFilter(IServiceProvider serviceProvider , IDefenceErrorHandler defenceErrorHandler)
    {
        _serviceProvider = serviceProvider;
        _defenceErrorHandler = defenceErrorHandler;
        DefenceFactory.Configure(_defenceErrorHandler);
    }


    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        using var scope = _serviceProvider.CreateScope();

        var models = context.ActionArguments.Values.ToList();

        foreach (var model in models)
        {
            Type[] typeArgs = {model.GetType()};

            var validatorType = typeof(IDefenceValidator<>).MakeGenericType(typeArgs);

            if (scope.ServiceProvider.GetService(validatorType) is IDefenceValidator validator)
                await validator.Validate(model);
        }
        
        var validationErrors = _defenceErrorHandler.GetCurrentRequestErrors();

        if (validationErrors.Any())
        {
            context.Result = new JsonResult(new DefenceResult(validationErrors));
            
            _defenceErrorHandler.ClearCurrentRequestErrors();
        }
        else
            await next();
    }
}