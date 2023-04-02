using System;

namespace Figure
{
    internal class Triangle : Figure
    {
        public Triangle(double side1, double side2, double side3)
        {
            SideOne = side1;
            SideTwo = side2;
            SideThree = side3;
        }
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
                    throw new Exception("Сторона1 задана неверно.");
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
                    throw new Exception("Сторона2 задана неверно.");
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
                    throw new Exception("Сторона3 задана неверно.");
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
                if (SideOne<(SideTwo+SideThree) & (SideTwo<(SideOne+SideThree) & (SideThree<(SideOne+SideTwo))))
                {
                    return Math.Sqrt(HalfP * (HalfP - sideOne) * (HalfP - sideTwo) * (HalfP - sideThree));
                }
                else
                {
                    throw new Exception("Такой треугольник не существует.");
                }
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