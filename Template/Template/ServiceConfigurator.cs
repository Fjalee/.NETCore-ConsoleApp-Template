using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLog.Extensions.Logging;
using NLog;
using Microsoft.Extensions.Logging;
using Template;

namespace Youtube_Playlist_Manager
{
    public static class ServiceConfigurator
    {
        public static IServiceCollection ConfigureServices(IConfiguration config)
        {
            var services = new ServiceCollection();

            services
                .AddAutoMapper(typeof(Program))
                .Configure<AppSettingsOptions>(
                    config.GetSection("AppSettings"))
                .Configure<TestObjectOptions>(
                    config.GetSection("TestObject"));

            services.AddLogging(builder =>
            {
                builder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                builder.AddNLog("nlog.config");
            });
            LogManager.Configuration = new NLogLoggingConfiguration(config.GetSection("NLog"));

            //services
            //.AddTransient<IExampleClass, ExampleClass>();             //delete this line (its from template) 

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
