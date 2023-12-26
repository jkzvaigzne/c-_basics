using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return (decimal)Math.PI * radius * radius;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return length * width;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return 0.5m * ground * height;
        }
    }
}
