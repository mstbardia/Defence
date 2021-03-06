using Defence.Abstractions;
using Defence.Internals.Abstractions;
using Defence.Internals.Handlers;
using Defence.Internals.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Defence;

/// <summary>
/// Extension methods for setting up Defence to protect your
/// request content after model binding and before action execution in an <see cref="IServiceCollection" />.
/// </summary>
public static class DefenceServiceExtension
{
    /// <summary>
    /// Add and configure Defence services to specifies <see cref="IServiceCollection" />.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection" /> to add services to.</param>
    /// <param name="configuration">The <see cref="DefenceServiceConfiguration" /> to configure Defence.</param>
    /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
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
        if (config.ImplementedValidatorTypeKind != null)
            services.Scan(scan => scan
                .FromAssemblies(config.ImplementedValidatorTypeKind.Assembly)
                .AddClasses(classes => classes.AssignableTo(typeof(IValidator)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        return services;
    }
}