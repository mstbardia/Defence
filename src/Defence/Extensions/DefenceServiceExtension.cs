using System;
using Defence.Handlers.Internals;
using Defence.Internals.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Defence.Core;
using Defence.Core.Abstractions;
using Defence.Core.Handlers.Internals.Abstractions;

namespace Defence.Extensions;

public static class DefenceServiceExtension
{
    public static IServiceCollection AddDefence(this IServiceCollection services, Action<DefenceServiceConfiguration> configuration)
    {
        services.AddHttpContextAccessor();

        services.AddSingleton<IConfigureOptions<MvcOptions>, DefenceMvcOptions>();

        services.AddSingleton<IDefenceContextHandler, DefenceContextHandler>();
        
        services.AddSingleton<IDefenceErrorHandler, DefenceErrorHandler>();
        
        var config = new DefenceServiceConfiguration();

        configuration(config);
 
        services.Configure<DefenceServiceOptions>(options =>
        {
            options.ThrowExceptions = config.ThrowExceptions;
        });

        if (config.ValidatorTypeExample != null)
            services.Scan(scan => scan
                .FromAssemblies(config.ValidatorTypeExample.Assembly)
                .AddClasses(classes => classes.AssignableTo(typeof(IDefenceValidator)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

        return services;
    }
}