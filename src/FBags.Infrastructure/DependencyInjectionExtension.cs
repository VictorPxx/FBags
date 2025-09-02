using FBags.Domain.Repositories.Bags;
using FBags.Infrastructure.DataAccess;
using FBags.Infrastructure.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace FBags.Infrastructure;
public static class DependencyInjectionExtension
{
    
    public static void AddInfrastructure(
        this IServiceCollection services
        , IConfiguration configuration)
    {
        AddRepositories(services);
        AddDbContext(services, configuration);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IBagsRepository, BagRepository>();
    }

    private static void AddDbContext (
        IServiceCollection services, 
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Connection");
        var serverVersion = new MySqlServerVersion(new Version(8,0,41));
        
        services.AddDbContext<FBagsDbContext>(
            config => config.UseMySql(connectionString, serverVersion));
    }
}
