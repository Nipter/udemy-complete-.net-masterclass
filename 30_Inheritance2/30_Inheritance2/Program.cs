namespace _30_Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe", 26, "Sales Rep", 1234);
            joe.DisplayEmplyeeInfo();

            Manager carl = new Manager("Carl", 45, "manager", 123456, 7);
            carl.DisplayManagerInfo();
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        /// <summary>
        /// Makes our object older
        /// </summary>
        /// <param name="years">
        /// The parameter that indicates the amount of years that object should age
        /// </param>
        /// <returns>
        /// Returns the new age after aging/becoming older
        /// </returns>
        public int BecomeOlder(int years)
        {
            Age = Age + years;
            return Age;
        }
    }
    // sealed keyword ensure that other classes can not inherit from Employee
    //public sealed class Employee: Person
    public class Employee: Person
    {
        public string JobTitle { get; private set; }
        public int EmplyeeID { get; private set; }
        public Employee(string name, int age, string jobTitle, int employeeID) : base(name, age) {
            JobTitle = jobTitle;
            EmplyeeID = employeeID;
            Console.WriteLine("Emplyee constructor called");
        }

        public void DisplayEmplyeeInfo()
        {
            base.DisplayPersonInfo();
            Console.WriteLine($"JobTitle: {JobTitle}, EmplyeeID: {EmplyeeID}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }
        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize)
            : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
            Console.WriteLine("Manager constructor called");
        }

        public void DisplayManagerInfo()
        {
            base.DisplayEmplyeeInfo();
            Console.WriteLine($"TeamSize: {TeamSize}");
        }
    }
}
