using Microsoft.Extensions.DependencyInjection;
using TesteTecnico.Api.Interfaces;
using TesteTecnico.Api.Models.Notificacoes;
using TesteTecnico.Api.Services;

namespace TesteTecnico.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<ICreditoService, CreditoService>();

            return services;
        }
    }
}
