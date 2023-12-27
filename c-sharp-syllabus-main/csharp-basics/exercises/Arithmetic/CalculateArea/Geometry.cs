using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static decimal AreaOfCircle(decimal radius)
        {
            return (decimal)Math.PI * radius * radius;
        }

        public static decimal AreaOfRectangle(decimal length, decimal width)
        {
            return length * width;
        }

        public static decimal AreaOfTriangle(decimal ground, decimal height)
        {
            return 0.5m * ground * height;
        }
    }
}
