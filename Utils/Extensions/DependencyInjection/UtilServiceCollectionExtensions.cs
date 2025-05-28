using Microsoft.Extensions.DependencyInjection;

namespace Pupo4ek.Utils.Extensions.DependencyInjection;

/// <summary>
/// Extension methods for IServiceCollection to register utility services.
/// </summary>
public static class UtilServiceCollectionExtensions
{
    /// <summary>
    /// Adds an IDateProvider implementation to the service collection as a singleton.
    /// </summary>
    /// <param name="services">The IServiceCollection to add the service to.</param>
    /// <returns>The IServiceCollection so that additional calls can be chained.</returns>
    public static IServiceCollection AddDateProvider(this IServiceCollection services)
    {
        services.AddSingleton<IDateProvider, DateProvider>();
        return services;
    }
    
    /// <summary>
    /// Adds an IGuidProvider implementation to the service collection as a singleton.
    /// </summary>
    /// <param name="services">The IServiceCollection to add the service to.</param>
    /// <returns>The IServiceCollection so that additional calls can be chained.</returns>
    public static IServiceCollection AddGuidProvider(this IServiceCollection services)
    {
        services.AddSingleton<IGuidProvider, GuidProvider>();
        return services;
    }
}