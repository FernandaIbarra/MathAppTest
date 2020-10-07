using System;
using System.Collections.Generic;
using System.Text;

namespace MathApp
{
    public class Quadrilateral : Shape
    {
        public double a { get; set; }

        public double b { get; set; }

        private const string square = "square";
        private const string rectangle = "rectangle";

        public override string name
        {
            get
            {
                if (a == b)
                {
                    return square;
                }
                else
                {
                    return rectangle;
                }
            }
        }
        public override double perimeter
        {
            get
            {
                return (a + b) * 2;
            }
        }
        public override double area
        {
            get
            {
                return a * b;
            }
        }

        public Quadrilateral(double side)
        {
            this.a = this.b = side;
        }

        public Quadrilateral(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
