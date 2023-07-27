using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
           
            start:
            Console.WriteLine("Press c For Circle");
            Console.WriteLine("Press r For Reactangle");
            Console.WriteLine("Press t For Triangle");
           string Exp= Console.ReadLine();
            switch (Exp)
            {
                case "c":
                   
                    
                    Console.WriteLine("enter Radius First");
                    double r= double.Parse(Console.ReadLine());
                    Circle circle = new Circle(r);
                    Console.WriteLine(" Information of circle:");
                    circle.PrintInfo();
                    break;
                case "r":

                    
                    Console.WriteLine("enter Length First");
                    double l = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter Breath First");
                    double w= double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(l, w);
                    Console.WriteLine("\n Information of Rectangle Info:");
                    rectangle.PrintInfo();
                    break;
                case "t":
                    
                    Console.WriteLine("enter Side A");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter Side B");
                    double b= double.Parse(Console.ReadLine());
                    Console.WriteLine("enter Side c");
                    double c= double.Parse(Console.ReadLine());
                    Triangle triangle = new Triangle(a, b, c);
                    Console.WriteLine("\n Information of Triangle:");
                    triangle.PrintInfo();
                    break;
               default: Console.WriteLine("invalid Key");
                    break;

            }
            Console.WriteLine(" Would you like to Continue press y for continue");
            string xp = Console.ReadLine();
            if (xp == "y")
            {
                goto start;
            }
           
        }
    }
}
