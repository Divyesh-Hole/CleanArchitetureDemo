using CleanArchitectureDemo.Application.Services;
using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Infrastructure.Data;
using CleanArchitectureDemo.Infrastructure.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Presentation;

public static class ServiceExtension
{
    public static IServiceCollection AddModuleServices(
        this IServiceCollection services,
        IConfigurationManager config,
        Serilog.ILogger logger)
    {
        // Setup DbContext
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("CleanArchitectureDemo")); // InMemoryDatabase for demo purposes

        // Register Services
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<UserService>();
        logger.Information("{Module} module services register", "User");

        return services;
    }
}
