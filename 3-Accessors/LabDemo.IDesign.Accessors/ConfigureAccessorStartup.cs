using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LabDemo.IDesign.Accessors;

public static class ConfigureAccessorStartup
{
    internal const string NAME_OF_POSTGRES_CONNECTION_CONFIG_KEY = "LabworkPostgres";

    public static IServiceCollection ConfigureServices(IConfiguration configuration, IServiceCollection services)
    {
        var connectionString = configuration.GetConnectionString(NAME_OF_POSTGRES_CONNECTION_CONFIG_KEY);

        if (string.IsNullOrWhiteSpace(connectionString))
            throw new InvalidDataException($"Could not find postgrs exception string under key, {NAME_OF_POSTGRES_CONNECTION_CONFIG_KEY}");

        services.AddDbContext<UserLabsDataContext>(options => options.UseNpgsql(connectionString));
        return services;
    }
}
