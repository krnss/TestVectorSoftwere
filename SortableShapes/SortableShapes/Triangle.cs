using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    class Triangle : Shape
    {
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double Base { get; set; }
        public double Height { get; set; }
        public override double GetArea { get => Base * Height / 2; }


    }
}
