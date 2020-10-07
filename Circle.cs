using System;
using System.Collections.Generic;
using System.Text;

namespace MathApp
{
    public class Circle : Shape
    {
        public double radius { get; set; }
        public override double perimeter
        {
            get
            {
                return ((2 * Math.PI) * radius);
            }
        }
        public override double area
        {
            get
            {
                return (Math.PI) * radius * radius;
            }
        }

        public override string name { get
            {
                return "circle";
            } 
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

    }
}
