using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonLibrary
{
    public abstract class Polygon
    {
        public double Base { get; protected set; }

        public double Length { get; protected set; }

        public double Width { get; protected set; }

        public double Height { get; protected set; }

        public double Side { get; protected set; }

        public double Diagonal1 { get; protected set; }

        public double Diagonal2 { get; protected set; }

        public double ShortBase { get; protected set; }

        public double LongBase { get; protected set; }

        public double Perimeter { get; protected set; }

        public double Apothem { get; protected set; }

        public abstract double getArea();
    }
}
