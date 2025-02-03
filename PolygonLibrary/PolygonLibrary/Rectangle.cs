using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonLibrary
{
    public class Rectangle : Polygon
    {
        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public override double getArea()
        {
            return Width * Length;
        }
    }
}
