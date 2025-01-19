using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            OddNumbers(numbers);
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd numbers:");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;


            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
