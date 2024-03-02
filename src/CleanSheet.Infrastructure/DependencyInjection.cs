using CleanSheet.Domain.Repositories;
using CleanSheet.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanSheet.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(connectionString));

        services.AddRepositories();

        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
