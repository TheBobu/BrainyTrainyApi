using BrainyTrainy.BusinessLogic.Implementations;
using BrainyTrainy.BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BrainyTrainy.BusinessLogic
{
    public static class ContainerConfig
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserBusinessLogic, UserBusinessLogic>();
            return services;
        }
    }
}