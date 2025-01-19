namespace _41_MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celling: " + Math.Ceiling(15.4));
            Console.WriteLine("Floor: " + Math.Floor(15.4));

            Console.WriteLine("Lower value: " + Math.Min(15.4, 16));
            Console.WriteLine("Higher value: " + Math.Max(15.4, 16));

            Console.WriteLine("Power value: " + Math.Pow(3, 16));
            Console.WriteLine("PI value: " + Math.PI);

            Console.WriteLine("Sqrt value: " + Math.Sqrt(24));

            Console.WriteLine("Abs value: " + Math.Abs(-24));

            Console.WriteLine("Cos value: " + Math.Cos(1));
        }
    }
}
