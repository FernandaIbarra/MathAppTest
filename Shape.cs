using System;
using System.Collections.Generic;
using System.Text;

namespace MathApp
{
    public abstract class Shape
    {
        abstract public string name { get; }
        abstract public double perimeter { get; }
        abstract public double area { get; }
    }
}
