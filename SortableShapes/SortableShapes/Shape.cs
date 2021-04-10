using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    class Shape : IComparable
    {
        public virtual double GetArea { get; }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Shape shape = obj as Shape;
            return this.GetArea.CompareTo(shape.GetArea);
        }
    }
}
