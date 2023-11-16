using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Application.Services.Authentication;

namespace BuberDinner.Application;

// A Single static extension method that registers everything for the application layer.

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}