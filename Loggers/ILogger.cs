
namespace Loggers
{
    public interface ILogger
    {
        void WriteInformation(string message);
        void WriteWarning(string message);
        void WriteError(string message);
    }
}
