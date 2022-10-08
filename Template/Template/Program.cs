using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Template
{
    public class Program
    {
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            //serviceProvider.GetService<IExample>();             //getting example class implementation
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var config = SetupConfiguration();

            //services
            //    .AddTransient<IExampleClass, ExampleClass>();             //injecting example class implementation
        }

        private static IConfiguration SetupConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
        }
    }
}
