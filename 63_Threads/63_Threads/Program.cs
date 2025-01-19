namespace _63_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 1");          
            //Console.WriteLine("Hello, World! 3");
            //Console.WriteLine("Hello, World! 4");

            //new Thread(() =>
            //{
            //    Thread.Sleep(100);
            //    Console.WriteLine("Hello, World! 2");
            //}).Start();
            //----------------------------------------------

            //var taskCompletionSource = new TaskCompletionSource<bool>();
            //var thread = new Thread(() => {
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //    Thread.Sleep(1000);
            //    taskCompletionSource.TrySetResult(true);
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            //});
            //thread.Start();
            //var test = taskCompletionSource.Task.Result;
            //Console.WriteLine("Task was done: {0}", test);
            //----------------------------------------------

            //new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            //})
            //{ IsBackground = true}.Start();

            //Enumerable.Range(0, 1000).ToList().ForEach(f =>
            //{
            //    ThreadPool.QueueUserWorkItem((o) =>
            //    {
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            //    });
            //});
            //----------------------------------------------

            Console.WriteLine("Main Thread started");

            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);

            thread1.Start();
            thread2.Start();       

            if(thread1.Join(1000)) {
                Console.WriteLine("Thread1Function done");
            } 
            else
            {
                Console.WriteLine("Thread1Function wasn't done within 1 sec");
            }
            for (int i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1 is still alive");
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Thread1 compleated");
                }
            }
    

            thread2.Join();
            Console.WriteLine("Main Thread ended");
        }

        public static void Thread1Function()
        { 
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to caller");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
