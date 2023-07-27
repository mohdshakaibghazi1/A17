using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17
{
    public class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public override double Perimeter
        {
            get { return 2 * Math.PI * Radius; }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
