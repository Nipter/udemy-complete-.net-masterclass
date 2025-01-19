namespace _29_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.ShowFields();

            Dog myDog = new Dog();
            myDog.MakeSound();
            myDog.Eat();
            myDog.AccessField();
            myDog.ShowFields();

            Cat myCat = new Cat();
            myCat.MakeSound();
        }
    }
    // Base class (Parent Class or Superclass):
    // The class whose members are inherited
    class Animal
    {
        // access modifiers
        public int publicField;
        protected int protectedField;
        private int privateField;

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }


        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, Protected: {protectedField}, Private: {privateField}");
        }
    }

    // Derived Class (Child Class or Subclass):
    // The class that inherits the members of the base class
    class Dog: Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Barking...");
        }

        public void AccessField()
        {
            // Accessable in all class
            publicField = 1;
            // Only accessable in child class
            protectedField = 2;
            // Can not be access. Only accessable in scope in a class
            // privateField = 3;
        }
    }


    class Cat : Animal
    {
       public override void MakeSound()
       {
            base.MakeSound();
            Console.WriteLine("Cat is meowing");
       }
    }

    class Collie: Dog
    {
        public void Running()
        {
            Console.WriteLine("Running...");
        }
    }
}
