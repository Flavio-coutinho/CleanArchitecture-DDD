using BuberDinner.Aplication.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Aplication;

public static class DependencyInjection
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
         services.AddScoped<IAuthenticationService, AuthenticationService>();

         return services;

    }
}