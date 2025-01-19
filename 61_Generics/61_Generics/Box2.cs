using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Generics
{
    internal class Box2<T, K>
    {
        public T First { get; set; }
        public K Second { get; set; }

        public Box2(T first, K second)
        {
            First = first;
            Second = second;
        }

        public void Display()
        {
            Console.WriteLine("First: " + First + ", Second: " + Second);
        }
    }
}
