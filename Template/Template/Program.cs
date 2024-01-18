using Microsoft.Extensions.DependencyInjection;
using Template.Helpers.Interfaces;

namespace Template
{
    public class Program
    {
        private static void Main()
        {
            var services = ServiceConfigurator.ConfigureServices(
                ServiceConfigurator.SetupConfiguration());
            var serviceProvider = services.BuildServiceProvider();

            var exceptionsHelper = serviceProvider.GetService<IExceptionsHelper>();
            AppDomain.CurrentDomain.UnhandledException += exceptionsHelper.UnhandledExceptionTrapper;

            //var config = serviceProvider.GetService<IOptions<AppSettingsOptions>>().Value;       //delete this line (its from template)
            //var testValFromConfig = config.TestObject.TestValue;     //delete this line (its from template)
        }
    }

    //public interface IExampleClass { }       //delete this line (its from template)

    //public class ExampleClass : IExampleClass       //delete this line (its from template)
    //{
    //    private readonly AppSettingsOptions _config;

    //    public ExampleClass(IOptions<AppSettingsOptions> configOptions)
    //    {
    //        _config = configOptions.Value;
    //        var testValFromConfig = _config.TestObject.TestValue;     //delete this line (its from template)
    //    }
    //}
}
