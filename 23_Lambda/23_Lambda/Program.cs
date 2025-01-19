namespace _23_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A lambda expression consists of 2 Parts
            // 1. Parameters
            // 2. Expression or Statement Blok

            // Parameters are written on the left side of =>
            // (This symbol is read as "goes to" or "becomes")
            // The expression or action to perform is on the right side.

            // This reads as:
            // "Take an input x and turn it into x multiplied by x."
            // x => x * x;

            List<int> numbers = new List<int> { 12, 3, 5, 25, 23};
            Predicate<int> isGreaterThenTen = x => x >= 10;

            // This will return a list of numbers >= 10
            List<int> heigherEqualTen = numbers.FindAll(isGreaterThenTen);

            // In C#, a delegate is a like a pointer or a reference to a method.
            // It allows you to pass methods as arguments to other methods,
            // store them in variables, and call them later.
            // This is useful when you want your code to be flexible and
            // able to handle different behaviors that aren't predetermined.
            Predicate<int> predicate = isZero;
        }

        static int Squaring(int num1)
        {
            return num1 * num1;
        }

        static bool isZero(int num1)
        {
            return num1 == 0;
        }
    }
}
