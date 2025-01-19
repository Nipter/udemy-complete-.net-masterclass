namespace _42_Delegates
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
        // 1. Declaration:
        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            // Delegates define a method signature,
            // and any method assigned to a delegate
            // must match this signature.


            // 2. Instantiation:
            Notify notifyDelegate = ShowMessage;
            Notify notifyDelegate2 = new Notify(notifyDelegate);

            // 3. Invocation:
            notifyDelegate("Hello world");

            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Text");

            logHandler = logger.LogToFile;
            logHandler("Text");
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
