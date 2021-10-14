using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.O2
{
    public class Calculator
    {
        public double CalculateArea(object shape)
        {
            double area = 0;

            if (shape is Rectangle)
            {
                Rectangle rectangle = shape as Rectangle;
                area = rectangle.Height * rectangle.Width;
            }
            else if (shape is Circle)
            {
                Circle circle = shape as Circle;
                area = Math.PI * circle.Radius * circle.Radius;
            }

            return area;
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }

        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }
}
