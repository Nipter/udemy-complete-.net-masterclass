namespace _39_Enum
{
    enum Day { Mo = 1, Tu = 3, We, Th, Fr, Sa, Su};
    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);
            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);
            Console.WriteLine((int)Day.Tu);
            Console.WriteLine((int)Day.We);
        }
    }
}
