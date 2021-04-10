using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
        }

        public double Side { get; set; }

        public override double GetArea { get => Side * Side; }
    }
}
