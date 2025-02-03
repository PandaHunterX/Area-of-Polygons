using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonLibrary
{
    public class Pentagon : Polygon
    {
        public Pentagon(double perimeter, double apothem)
        {
            this.Perimeter = perimeter;
            this.Apothem = apothem;
        }

        public override double getArea()
        {
             return 0.5 * (Perimeter * Apothem);
        }
    }
}
