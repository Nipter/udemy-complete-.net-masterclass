namespace _62_GenericsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailTask = new EmailTask();
            emailTask.Message = "Hello, this is a test email";
            emailTask.Recipient = "example@example.com";

            var reportTask = new ReportTask()
            {
                ReportName = "Annual Report",
            };

            var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute()); 
        }
    }
}
