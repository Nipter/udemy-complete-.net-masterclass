namespace _26_Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int? is a nullable int
            int? age = null;

            if (age.HasValue)
            {
                Console.WriteLine("Age is: " + age.Value);
            }
            else
            {
                Console.WriteLine("Age is not specified");
            }
            
        }
    }
}
