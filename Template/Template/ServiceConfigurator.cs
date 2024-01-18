using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;

namespace Template
{
    public static class ServiceConfigurator
    {
        public static IServiceCollection ConfigureServices(IConfiguration config)
        {
            var services = new ServiceCollection();

            services.AddAutoMapper(typeof(Program));

            services.AddOptions<AppSettingsOptions>()
                .Bind(config.GetSection("AppSettings"))
                .ValidateDataAnnotationsRecursively()
                .ValidateEagerly();

            services.AddLogging(builder =>
            {
                builder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                builder.AddNLog("nlog.config");
            });
            LogManager.Configuration = new NLogLoggingConfiguration(config.GetSection("NLog"));

            services
                .AddTransient<IExceptionsHelper, ExceptionsHelper>();

            return services;
        }

        public static IConfiguration SetupConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile($"local-appsettings.json", false)
                .AddJsonFile($"appsettings.json", false)
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
        }
    }
}
