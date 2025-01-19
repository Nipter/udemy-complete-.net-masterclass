
using System.Reflection;

namespace _61_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Box<int> box = new Box<int>();
            //box.Content = 42;
            //Console.WriteLine(box.Log());

            //Box<string> box2 = new Box<string>{Content = "Text"};
            //Console.WriteLine(box2.Log());
            //-----------------------------------

            //Box<string> box = new Box<string>("Hello world");
            //box.UpdateContent("Hello world2");
            //Console.WriteLine(box.GetContent());
            //-----------------------------------

            //Box2<int, string> box = new Box2<int, string>(1, "first");
            //box.Display();
            //-----------------------------------

            //Logger logger = new Logger();
            //logger.Log<int>(10);
            //logger.Log<string>("Hello");

            //logger.Log(10);
            //logger.Log(new {Name="Jogn", Age=30});
            //-----------------------------------

            // This will not work when we use constrain
            //Box3<int> box = new Box3<int>();
            //Box3<Book> box2 = new Box3<Book>();
            //-----------------------------------

            //Repository<Product> repository = new Repository<Product>();
            //var product = new Product();
            //repository.Add(product);
            //-----------------------------------

            //var productOne = new Product();
            //var productTwo = new Product();
            //var result = Comperer.AreEqual(productOne, productTwo);
            //Console.WriteLine(result);
            //-----------------------------------

            //Type type = typeof(Program);
            //string name = "Tom";

            //if (name.GetType() == typeof(string))
            //{
            //    // logic
            //}
            //-----------------------------------

            //Action action = () => { Console.WriteLine("Hello world"); };
            //action();

            //Action<int> numPrint = (x) => Console.WriteLine(x);
            //numPrint(10);

            //Action<float, float, float> sum = (x, y, z) =>
            //{
            //    Console.WriteLine(x + y + z);
            //};
            //sum(1, 2, 3);
            //-----------------------------------

            //Func<string> getName = () =>
            //{
            //    return "Tom";
            //};
            //Console.WriteLine(getName());

            //Func<int, int, int> sum = (x, y) =>
            //{
            //    return x+y;
            //};
            //Console.WriteLine(sum(1,4));
            //-----------------------------------

            //Predicate<int> isEven = (x) => x % 2 == 0;
            //Console.WriteLine(isEven(2));
            //-----------------------------------
        }

        //class Product : IEntity
        //{
        //    public int Id { get; }
        //}
        //class Book
        //{

        //}

        //-----------------------------------
        //internal interface IEntity
        //{
        //    int Id { get; }
        //}
        //internal interface IRepository<T> where T : IEntity
        //{
        //    void Add(T entity);
        //    void Remove(T entity);
        //}

        //internal class Product : IEntity
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}

        //internal class ProductRepository : IRepository<Product>
        //{
        //    public void Add(Product entity)
        //    {

        //    }

        //    public void Remove(Product entity)
        //    {

        //    }
        //}


        // ---------------------------------------

        internal interface IRepository<T>
        {
            void Add(T entity);
            void Remove(T entity);
        }

        internal class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        internal class Repository<T> : IRepository<T>
        {
            public void Add(T entity)
            {

            }

            public void Remove(T entity)
            {

            }
        }
    }
}
