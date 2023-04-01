using System;

namespace Figure
{
    internal class Triangle : Figure
    {
        public double sideOne;
        public double SideOne
        {
            get
            {
                return sideOne;
            }
            set
            {
                if (value < 0)
                {
                    sideOne = 0;
                }
                else
                {
                    sideOne = value;
                }
            }
        }

        public double sideTwo;
        public double SideTwo
        {
            get
            {
                return sideTwo;
            }
            set
            {
                if (value < 0)
                {
                    sideTwo = 0;
                }
                else
                {
                    sideTwo = value;
                }
            }
        }

        public double sideThree;
        public double SideThree
        {
            get
            {
                return sideThree;
            }
            set
            {
                if (value < 0)
                {
                    sideThree = 0;
                }
                else
                {
                    sideThree = value;
                }
            }
        }

        public double HalfP
        {
            get
            {
                return 0.5 * (sideOne + sideTwo + sideThree);
            }
        }
        public override double Area
        {
            get
            {
                return Math.Sqrt(HalfP * (HalfP - sideOne) * (HalfP - sideTwo) * (HalfP - sideThree));
            }
        }
        public override double Perimeter
        {
            get
            {
                return sideOne + sideTwo + sideThree;
            }
        }
        public override string ToString()
        {
            return $"Triangle Area: {Area}\nTriangle Perimeter: {Perimeter}\n";
        }
    }
}