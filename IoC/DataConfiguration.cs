using Data;
using Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DataConfiguration
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IPollRepository, PollRepository>();
            services.AddTransient<IPollOptionRepository, PollOptionRepository>();

            return services;
        }
    }
}
