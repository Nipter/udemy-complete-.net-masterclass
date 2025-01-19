namespace _19_WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());  

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();


            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            Console.WriteLine($"Average temperature is: {CalculateAverage(temperature)}");
            //Console.WriteLine($"The max temperature was: {temperature.Max()}");
            //Console.WriteLine($"The min temperature was: {temperature.Min()}");
            Console.WriteLine($"The min temperature was: {MinTemperature(temperature)}");
            Console.WriteLine($"The max temperature was: {MaxTemperature(temperature)}");
            Console.WriteLine($"The most common condition was: {MostCommonConditions(weatherConditions, conditions)}");
            Console.WriteLine();
        }

        static string MostCommonConditions( string[] weatherConditions, string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < weatherConditions.Length; j++)
                {
                    if(weatherConditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if(tempCount >count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }

        static double CalculateAverage(int[] temperature)
        {
            int sum = 0;

            foreach (var item in temperature)
            {
                sum += item;
            }

            return sum / temperature.Length;
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (var item in temperature)
            {
                if(item < min)
                {
                    min = item; 
                }
            }
            return min;
        }

        static int MaxTemperature(int[] temperature)
        {
            int max = temperature[0];

            foreach (var item in temperature)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
