using Business;
using Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class BusinessConfiguration
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddTransient<IPollBusiness, PollBusiness>();
            services.AddTransient<IPollOptionBusiness, PollOptionBusiness>();

            return services;
        }
    }
}
