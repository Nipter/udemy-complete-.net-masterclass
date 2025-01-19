namespace _45_MulticastDelegates
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console log: " + message);
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File log: " + message);
        }
    }
    internal class Program
    {
        public delegate void Notify(string message);
        static void Main(string[] args)
        {

            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;


            logHandler("Log info");

            foreach (LogHandler hanlder in logHandler.GetInvocationList())
            {
                try
                {
                    hanlder("Event occured with error handling");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: " + e.Message);
                }
            }
            if(IsMethodInDelegate(logHandler, logger.LogToConsole))
            {
                logHandler -= logger.LogToConsole;
                Console.WriteLine("Log to console removed");
            } else
            {
                Console.WriteLine("Log to console not found");
            }
            
            InvokeSafely(logHandler, "Log info");
        }

        static void InvokeSafely(LogHandler loghHandler, string message)
        {
            LogHandler tempLogHandler = loghHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method) {
            if(logHandler == null)
            {
                return false;
            }
            foreach (var item in logHandler.GetInvocationList())
            {
                if(item == (Delegate) method)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
