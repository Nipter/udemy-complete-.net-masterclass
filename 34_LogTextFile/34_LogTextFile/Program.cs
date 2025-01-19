namespace _34_LogTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The @ sign in C# is used to denote a verbatim string literal 
            string directorypath = @"C:\Logs";
            string filePath = Path.Combine(directorypath, "log.txt");

            if (!Directory.Exists(directorypath))
            {
                Directory.CreateDirectory(directorypath);
            }
            File.AppendAllText(filePath, "Hello world");
        }
    }
}
