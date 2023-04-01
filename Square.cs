using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Square : Figure
    {
        public double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value < 0)
                {
                    side = 0;
                }
                else
                {
                    side = value;
                }
            }
        }

        public override double Area
        {
            get
            {
                return side * side;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 4 * side;
            }
        }

        public override string ToString()
        {
            return $"Square Area: {Area}\nSquare Perimeter: {Perimeter}\n";
        }
    }
}