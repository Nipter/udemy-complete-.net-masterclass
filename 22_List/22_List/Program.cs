namespace _22_List
{
    internal class Program
    {
        public class Product
        {
            public string  Name { get; set; }
            public double Price { get; set; }
        }
        static void Main(string[] args)
        {
            // Declaring and initializing the list
            //List<string> colors = new List<string>();

            //colors.Add("red");
            //colors.Add("blue");
            //colors.Add("green");
            //colors.Add("red");

            //List<string> colors = ["red", "blue", "green", "red"];

            //Console.WriteLine("Colors:");
            //foreach (string color in colors)
            //{
            //    Console.WriteLine("Color: {0}", color );
            //}

            //bool isDeletingSuccessful = colors.Remove("red");
            //while (isDeletingSuccessful)
            //{
            //    isDeletingSuccessful = colors.Remove("red");
            //}

            //Console.WriteLine("Colors:");
            //foreach (string color in colors)
            //{
            //    Console.WriteLine("Color: {0}", color);
            //}
            // --------------------------

            //List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18};

            //Console.WriteLine("Numbers:");
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers.Sort();

            //Console.WriteLine("Numbers:");
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Predicate<int> isGreaterThenTen = x => x >= 10;

            //// This will return a list of numbers >= 10
            //List<int> heigherEqualTen = numbers.FindAll(isGreaterThenTen);


            //Console.WriteLine("Numbers:");
            //foreach (int number in heigherEqualTen)
            //{
            //    Console.WriteLine(number);
            //}

            //// This will return a list of numbers >= 10
            //bool containsTen = numbers.Any(x => x == 10);
            //Console.WriteLine("Do numbers contains 10: " + containsTen);
            // --------------------------

            List<Product> products = new List<Product>{ 
                new Product { Name = "Apple", Price = 0.8 } ,
                new Product { Name = "Bannana", Price = 0.3 } ,
                new Product { Name = "Cherry", Price = 3.8 } 
            };
            products.Add(new Product { Name = "Berries", Price = 2.99 });

            Console.WriteLine("Products");
            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for: {product.Price}");
            }

            List<Product> cheapProducts = products.Where(x => x.Price < 1.0).ToList();
            Console.WriteLine("Cheap products");
            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: {product.Name} for: {product.Price}");
            }
            // --------------------------
        }
    }
}
