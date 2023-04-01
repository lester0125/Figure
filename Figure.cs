using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal abstract class Figure
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
    }
}