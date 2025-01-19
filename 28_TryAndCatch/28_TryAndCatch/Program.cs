using System.Diagnostics;

namespace _28_TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Debug.WriteLine("Main method is running");
            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine());
                //int num1 = 0;
                int num2 = 20;

                result = num2 / num1;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't devide by zero: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please provide number: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number too high: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This always executes");
            }
  

            Console.WriteLine("Result: " + result);

            Console.WriteLine(GetUserAge(Console.ReadLine()));

            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Main: " + ex.Message);
            }
        }

        static int GetUserAge(string input)
        {
            int age;
            Console.WriteLine("Enter your age:");
            if(!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age");
            }
            if(age <0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }
            return age;
        }


        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            throw new Exception("Something went wrong!");
        }
    }
}
