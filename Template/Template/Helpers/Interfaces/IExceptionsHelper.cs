namespace Template.Helpers.Interfaces
{
    public interface IExceptionsHelper
    {
        void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e);
    }
}