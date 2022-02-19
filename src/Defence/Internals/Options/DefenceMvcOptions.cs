using Defence.Internals.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Defence.Internals.Options;

/// <summary>
/// as you maybe know , we set our filter in mvc filters here.
/// </summary>
internal class DefenceMvcOptions : IConfigureOptions<MvcOptions>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IDefenceErrorHandler _defenceErrorHandler;

    public DefenceMvcOptions(IServiceProvider serviceProvider, IDefenceErrorHandler defenceErrorHandler)
    {
        _serviceProvider = serviceProvider;
        _defenceErrorHandler = defenceErrorHandler;
    }

    public void Configure(MvcOptions options)
    {
        options.ModelValidatorProviders.Clear(); // suppress nullable reference type default validations (C# 8 and above)
        options.Filters.Add(new DefenceActionFilter(_serviceProvider, _defenceErrorHandler));
    }
}