using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.O3
{
    public class Calculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public override double Area()
        {
            return this.Width * this.Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
