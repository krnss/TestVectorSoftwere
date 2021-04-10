using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    static class ShapeHelper
    {
        public static void ShowArea(this List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i].GetArea);
            }
        }
    }
}
