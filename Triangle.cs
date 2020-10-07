using System;
using System.Collections.Generic;
using System.Text;

namespace MathApp
{
    public class Triangle : Shape
    {
        public double a { get; set; }

        public double b { get; set; }

        public double c { get; set; }

        private const string equilateral = "equilateral";
        private const string isosceles = "isosceles";
        private const string scalene = "scalene";

        public override string name { get
            {
                if ( a == b && b == c)
                {
                    return equilateral;
                } else
                {
                    if (( a == b && b != c) || (a == c && b != c) || (b == c && a != b))
                    {
                        return isosceles;
                    } else
                    {
                        return scalene;
                    }
                } 
            }
        }
        public override double perimeter
        {
            get
            {
                return a + b + c; 
            }
        }

        public override double area
        {
            get
            {
                switch (this.name)
                {
                    case equilateral:
                        return (Math.Sqrt(3) * a) / 2;
                    case isosceles:
                        if (a == b)
                        {
                            return ((a * a) / 2) * Math.Sin(c);
                        }else
                        {
                            if (b == c)
                            {
                                return ((b * b) / 2) * Math.Sin(a);
                            } else
                            {
                                return ((a * a) / 2) * Math.Sin(b);
                            }
                        }
                    default:
                        return ((b * c) * Math.Sin(a)) / 2;

                }
            }
        }

        public Triangle(double side)
        {
            this.a = this.b = this.c = side;
        }

        public Triangle(double duplicateSide, double uniqueSide)
        {
            this.a = this.b = duplicateSide;
            this.c = uniqueSide;
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
