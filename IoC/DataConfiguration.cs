using Data;
using Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Model;

namespace IoC
{
    public static class DataConfiguration
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IPollRepository, PollRepository>();
            services.AddTransient<IPollOptionRepository, PollOptionRepository>();
            services.AddTransient<IRepositoryBase<Poll>, RepositoryBase<Poll>>();

            return services;
        }
    }
}
