namespace _35_Decopuling
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        void ILogger.Log(string message)
        {
            // The @ sign in C# is used to denote a verbatim string literal 
            string directorypath = @"C:\Logs";
            string filePath = Path.Combine(directorypath, "log.txt");

            if (!Directory.Exists(directorypath))
            {
                Directory.CreateDirectory(directorypath);
            }
            File.AppendAllText(filePath, message);
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging yo database. {message}");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started");
            // some work
            _logger.Log("Work done");
        }
    }

    // Decoupling: The Application class depends on the ILogger interface
    // rather than specific implementations like FileLogger or DatabaseLogger.
    // This means you can easly switch the logging mechanism without changing
    // the Application class.
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger databaseLogger = new DatabaseLogger();
            app = new Application(databaseLogger);
            app.DoWork();
        }
    }
}
