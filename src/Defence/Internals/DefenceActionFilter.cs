using System;
using System.Linq;
using System.Net.Http;
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

    public DefenceActionFilter(IServiceProvider serviceProvider, IDefenceErrorHandler defenceErrorHandler)
    {
        _serviceProvider = serviceProvider;
        _defenceErrorHandler = defenceErrorHandler;
        Core.Defence.Configure(_defenceErrorHandler);
    }


    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        using var scope = _serviceProvider.CreateScope();

        var models = context.ActionArguments.Values.ToList();

        foreach (var model in models)
        {
            var validatorType = typeof(IDefenceValidator<>).MakeGenericType(model.GetType());

            if (scope.ServiceProvider.GetService(validatorType) is IValidator validator)
                await validator.Validate(model);
        }

        var validationResult = _defenceErrorHandler.GetCurrentRequestResult();

        if (validationResult != null)
        {
            context.Result = new ObjectResult(true)
            {
                StatusCode = 400,
                Value = validationResult
            };

            _defenceErrorHandler.ClearCurrentRequestErrors();
        }
        else
            await next();
    }
}