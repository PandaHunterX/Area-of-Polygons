using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonLibrary
{
    public class Rhombus : Polygon
    {
        public Rhombus(double diagonal1, double diagonal2)
        {
            this.Diagonal1 = diagonal1;
            this.Diagonal2 = diagonal2;
        }

        public override double getArea()
        {
            return (Diagonal1 * Diagonal2)/ 2;
        }
    }
}
