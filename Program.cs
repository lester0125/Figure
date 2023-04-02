using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Square square = new Square(10);
            Triangle triangle = new Triangle(10, 10, 10);

            Console.WriteLine(circle.ToString());
            Console.WriteLine(square.ToString());
            Console.WriteLine(triangle.ToString());
        }
    }
}