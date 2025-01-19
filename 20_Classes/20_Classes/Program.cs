namespace _20_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Class Car
            //Car audi = new Car("A3", "audi", false);
            //Car bmw = new Car("I7", "bmw", true);

            //Console.WriteLine("Please enter the Brand name");
            //audi.Brand = Console.ReadLine();

            //Console.WriteLine("Brand is: " + audi.Brand);
            //Console.WriteLine("Brand is: " + bmw.Brand);
            // -------------------------

            //Customer earl = new Customer("Earl");
            //Customer frankTheTank = new Customer("FrankTheTank", "Mainstreet 1", "123456789");
            //// Default Customer with no Arguments given
            //Customer myCustomer = new Customer();

            //Console.WriteLine("Name of Customer is: " + earl.Name);
            //Console.WriteLine("Name of Default Customer is: " + myCustomer.Name);

            //Console.WriteLine("Enter customer name");
            //myCustomer.Name = Console.ReadLine();
            // -------------------------

            //Console.WriteLine("Name of Default Customer is: " + myCustomer.Name);

            //Car audi = new Car("A3", "Audi", false);
            //audi.Drive();
            // -------------------------

            //Customer myCustomer = new Customer();
            //myCustomer.SetDetails("Tom", "Mainstreet 2", "123456");

            //Console.WriteLine("Customer name: " + myCustomer.Name);
            //Console.WriteLine("Customer address: " + myCustomer.Address);
            //Console.WriteLine("Customer number: " + myCustomer.ContactNumber);

            //Customer myCustomer2 = new Customer();
            //myCustomer2.SetDetails("Tom", "Mainstreet 3");

            //Console.WriteLine("Customer2 name: " + myCustomer2.Name);
            //Console.WriteLine("Customer2 address: " + myCustomer2.Address);
            //Console.WriteLine("Customer2 number: " + myCustomer2.ContactNumber);
            // -------------------------

            //Console.WriteLine(AddNum(1, 2));
            //Console.WriteLine(AddNum(firstNum: 3, secondNum: 4));
            //Console.WriteLine(AddNum(firstNum: 5, 6));
            //Console.WriteLine(AddNum(7, secondNum: 8));
            // -------------------------

            //Rectangle r1 = new Rectangle();
            //r1.Width = 5;
            //r1.Height = 5;

            //Console.WriteLine("Area of r1 is: " + r1.Area);
            // -------------------------

            //Customer.DoSomeCustomerStuff();
            // -------------------------

            //Car car = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car();

            //Console.WriteLine("Number of cars: " + Car.NumberOfCars);
            // -------------------------

            //Customer customer = new Customer();
            //Customer customer2 = new Customer();

            //customer.GetDetails();
            //customer2.GetDetails();

            //customer2.Password = "password";

            //Console.WriteLine("Customer id is: " + customer.Id);
            // -------------------------

            Rectangle r1 = new Rectangle("red");
            Rectangle r2 = new Rectangle("blue");

            r1.DisplayDetails();
            r2.DisplayDetails();
        }

        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
