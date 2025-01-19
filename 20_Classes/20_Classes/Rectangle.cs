using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Classes
{
    internal class Rectangle
    {
        // In C#, const and readonly are two keywords used to define non-modifiable fields,
        // but they differ in terms of when they are initialized and their usage context.

        // declaration of the field. Needs to be initialized during compile time
        public const int NumberOfCorners = 4;
        // declaration of field. Needs to be initialized during run time
        public readonly string Color;

        public double Width { get; set; }
        public double Height { get; set; }

        // Computed property
        // Read Only Prop
        public double Area
        {
            get { return Width * Height;}
        }

        public Rectangle(string color)
        {
            Color = color;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Rectangle detauls:");
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("NumberOfCorners: " + NumberOfCorners);
        }
    }
}
