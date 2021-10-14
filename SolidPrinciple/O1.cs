using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.O1
{
    public class Calculator
    {
        public double CalculateArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }

        public double Height { get; set; }
    }
}
