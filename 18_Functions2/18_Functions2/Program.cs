namespace _18_Functions2
{
    internal class Program
    {
        static int myResult;
        static void Main(string[] args)
        {
            myResult = AddTwoValues(1, 2);
            Console.WriteLine(myResult);
        }

        static int AddTwoValues(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
