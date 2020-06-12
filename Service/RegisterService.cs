using Microsoft.Extensions.DependencyInjection;

namespace Service
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IStudentLogic, StudentLogic>();
            return services;
        }
    }
}
