using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PolygonLibrary
{
    public class Square : Polygon
    {
        public Square(double side)
        {
            this.Side = side;
        }

        public override double getArea()
        {
            return Side * Side;
        }
    }
}
