using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonLibrary
{
    public class Triangle : Polygon
    {
        public Triangle(double base1, double height)
        {
            this.Base = base1;
            this.Height = height;
        }

        public override double getArea()
        {
            return 0.5 * (Base * Height);
        }
    }
}
