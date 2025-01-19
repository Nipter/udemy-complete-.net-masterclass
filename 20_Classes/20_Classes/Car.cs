using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Classes
{
    // It's internal, which means that
    // it can only be accessed from
    // within the same assembly.
    internal class Car
    {
        public static int NumberOfCars = 0;

        // member variable
        // private hides the variable from othe classes
        //private string _model = "";

        private string _brand = "";

        //private bool _isLuxury;

        // Property
        //public string Model { get => _model; set => _model = value; }
        public string Brand { 
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                } else
                {
                    return _brand;
                }
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _brand = "DEFAULTVALUE";
                } else
                {
                    _brand = value;
                }
                
            } 
        }

        public bool IsLuxury { get; set; }
        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public string Model { get; set; }
        // Constructor
        public Car(string model, string brand, bool isLuxury = false)
        {
            NumberOfCars++;
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"Car: {Brand} with model: {Model} is being created");
        }

        public Car()
        {
            NumberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }
    }
}
