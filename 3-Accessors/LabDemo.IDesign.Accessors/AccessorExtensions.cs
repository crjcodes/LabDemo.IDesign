using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LabDemo.IDesign.Accessors;

public static class AccessorExtensions
{
    internal const string NAME_OF_POSTGRES_CONNECTION_CONFIG_KEY = "LabworkPostgres";

    public static IServiceCollection ConfigureAccessorService(this IServiceCollection services, IConfiguration accessorConfiguration)
    {
        var connectionString = accessorConfiguration.GetConnectionString(NAME_OF_POSTGRES_CONNECTION_CONFIG_KEY);

        // TODO: 
        //if (string.IsNullOrWhiteSpace(connectionString))
        //    throw new InvalidDataException($"Could not find postgres exception string under configuration key, {NAME_OF_POSTGRES_CONNECTION_CONFIG_KEY}");

        return services;
    }
}
