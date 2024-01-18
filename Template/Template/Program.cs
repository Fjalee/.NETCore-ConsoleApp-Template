using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Youtube_Playlist_Manager;

namespace Template
{
    public class Program
    {
        private static ILogger<Program> _logger;

        private static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            _logger.LogCritical($"Unhandled exception occured\n {(Exception)e.ExceptionObject}");
            throw new Exception("Global Exception Handler");
        }

        private static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;

            var services = ServiceConfigurator.ConfigureServices(
                ServiceConfigurator.SetupConfiguration());
            var serviceProvider = services.BuildServiceProvider();

            _logger = serviceProvider.GetService<ILogger<Program>>();

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
