using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonLibrary
{
    public class Trapezoid : Polygon
    {
        public Trapezoid(double longbase, double shortbase, double height)
        {
            this.LongBase = longbase;
            this.ShortBase = shortbase;
            this.Height = height;
        }

        public override double getArea()
        {
            return 0.5 * (LongBase + ShortBase) * Height;
        }
    }
}
