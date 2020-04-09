using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Infra
{
    public class ConfigurationManager : IConfigurationManager
    {
        public PollConfiguration Configuration { get; }

        public ConfigurationManager(IOptions<PollConfiguration> configuration)
        {
            Configuration = configuration.Value;
            BuildEnviromentVariable();
        }

        private void BuildEnviromentVariable()
        {
            var configType = typeof(PollConfiguration);
            var properties = configType.GetProperties();
            foreach (PropertyInfo info in properties)
            {
                var envProperty = Environment.GetEnvironmentVariable(info.Name);
                if (string.IsNullOrEmpty(envProperty))
                {
                    continue;
                }

                configType.GetProperty(info.Name).SetValue(Configuration, envProperty);
            }
        }

        public static string GetConfiguration(IConfiguration configuration,
                                              string configurationName)
        {
            var envConfiguration = Environment.GetEnvironmentVariable(configurationName);
            if (!string.IsNullOrEmpty(envConfiguration))
            {
                return envConfiguration;
            }
            return configuration.GetSection(nameof(PollConfiguration)).GetSection(configurationName).Value;
        }
    }
}

