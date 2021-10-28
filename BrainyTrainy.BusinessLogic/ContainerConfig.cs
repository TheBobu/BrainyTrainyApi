using BrainyTrainy.BusinessLogic.Implementations;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Data;
using BrainyTrainy.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BrainyTrainy.BusinessLogic
{
    public static class ContainerConfig
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUserBusinessLogic, UserBusinessLogic>();
            services.AddScoped<IGameHistoryBusinessLogic, GameHistoryBusinessLogic>();
            return services;
        }
    }
}