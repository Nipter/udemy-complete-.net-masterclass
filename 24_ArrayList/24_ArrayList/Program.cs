using System.Collections;

namespace _24_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring an ArrayList
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList2 = new ArrayList(100);

            arrayList.Add(25);
            arrayList.Add("Hello");
            arrayList.Add(13.37);
            arrayList.Add(12f);

            // delete element with specific value
            arrayList.Remove(12f);

            // delete element at specific position
            arrayList.RemoveAt(1);

            Console.WriteLine("Number of elements:" + arrayList.Count);
            Console.WriteLine("ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
