using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Classes
{
    internal class Customer
    {
        private static int nextID = 0;
        // Read-only instance field initialized from the constructor. It can be only initialized once
        private readonly int _id;

        private string _password;

        public string Password { set
            {
                _password = value;
            }
        }
        // Read only property
        public int Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            _id = nextID++;
            Name = "DefaultName";
            Address = "No Address";
            ContactNumber = "No Contact Number";
        }
        // Custom Constructor
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextID++;
            Name =name;
        }

        // default/optional parameters
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine("Details about the customer");
            Console.WriteLine($"ID: {_id}" );
            Console.WriteLine($"Name: {Name}" );
            Console.WriteLine($"Address: {Address}" );
            Console.WriteLine($"ContactNumber: {ContactNumber}" );
        }

        // static method. Cannot be called on Object
        // static keyword is used to decalre
        // members of a class that belong to the class itself
        // rather than to any specific instance of the class
        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I'm doing some customer stuff");
        }
    }
}
