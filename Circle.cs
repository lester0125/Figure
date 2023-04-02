using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Circle : Figure
    {
        public Circle(double r)
        {
            Radius = r;
        }
        public double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Радиус задан неверно.");
                }
                else
                {
                    radius = value;
                }
            }
        }
        public override double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * radius;
            }
        }
        public override string ToString()
        {
            return $"Circle Area: {Area}\nCircle Perimeter: {Perimeter}\n";
        }
    }
}