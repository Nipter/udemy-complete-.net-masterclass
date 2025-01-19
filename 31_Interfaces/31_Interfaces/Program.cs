namespace _31_Interfaces
{
    public interface IAnimal
    {
        void MakeSund();
        void Eat(string food);
    }

    public class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog ate: " + food);
        }

        public void MakeSund()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Cat ate: " + food);
        }

        public void MakeSund()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSund();
            dog.Eat("Treat");

            Cat cat = new Cat();
            cat.MakeSund();
            cat.Eat("Fish");
        }
    }
}
