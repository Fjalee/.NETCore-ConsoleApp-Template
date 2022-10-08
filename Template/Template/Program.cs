using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog;
using NLog.Extensions.Logging;

namespace Template
{
    public class Program
    {
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            //serviceProvider.GetService<IExampleClass>();             //delete this line (its from template) 
            //var config = serviceProvider.GetService<IOptions<AppSettingsOptions>>()?.Value;       //delete this line (its from template)
            //var testValFromConfig = config?.TestObject?.TestValue;     //delete this line (its from template)
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var config = SetupConfiguration();

            services
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
        }

        private static IConfiguration SetupConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile($"local-appsettings.json", false)
                .AddJsonFile($"appsettings.json", false)
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
        }
    }
}
