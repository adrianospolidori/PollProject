using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IoC
{
    public class ServiceConfiguration
    {
        public IServiceProvider Services { get; private set; }

        public ServiceConfiguration(string connectionString)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection, connectionString);
            Services = serviceCollection.BuildServiceProvider();
        }

        public static void ConfigureServices(IServiceCollection services,
                                             string connectionString)
        {
            services.AddDbContext<PollContext>(options => options.UseSqlServer(connectionString, c => c.CommandTimeout(60)))
                .AddBusiness()
                .AddRepository();
        }
    }
}
