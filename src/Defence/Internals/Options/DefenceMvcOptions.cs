using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Defence.Core.Handlers.Internals.Abstractions;

namespace Defence.Internals.Options;

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
        options.Filters.Add(new DefenceActionFilter(_serviceProvider, _defenceErrorHandler));
    }
}