using Microsoft.Extensions.Logging;
using Template.Helpers.Interfaces;

namespace Template.Helpers
{
    public class ExceptionsHelper : IExceptionsHelper
    {
        private readonly ILogger<ExceptionsHelper> _logger;

        public ExceptionsHelper(ILogger<ExceptionsHelper> logger)
        {
            _logger = logger;
        }

        public void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            _logger.LogCritical($"Unhandled exception occured\n {(Exception)e.ExceptionObject}");
            throw new Exception("Global Exception Handler");
        }
    }
}
