namespace _43_GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5};
            string[] strings = { "1", "2", "3", "4" };

            PrintArray<int>(numbers);
            PrintArray<string>(strings);
        }

        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintArray<T>(T[] array) {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
