using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    static class Program
    {
        static void Main(string[] args)
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            var @base = 5D;
            var heaght = 2D;

            var shapes = new List<Shape> {
                new Square(side),
                new Square(side/2),
                new Circle(radius),
                new Circle(radius/2),
                new Triangle(@base,heaght)
            };
            shapes.ShowArea();
            
            shapes.Sort();

            shapes.ShowArea();

            Console.ReadLine();
        }        
    }
}
