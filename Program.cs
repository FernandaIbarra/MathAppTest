using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(3));
            shapes.Add(new Triangle(3));
            shapes.Add(new Quadrilateral(3));
            shapes.Add(new Quadrilateral(3.5));

            shapes.ForEach(s => Console.WriteLine($"{s.name} Area= {s.area} Perimeter= {s.perimeter}"));
            ///Requirement 5.
            /// Sort by area.
            shapes = shapes.OrderBy(s => s.area).ToList();
            Console.WriteLine("");
            Console.WriteLine("Sorted by area:");
            shapes.ForEach(s => Console.WriteLine($"{s.name} Area= {s.area}"));

            ///Requirement 5.
            /// Sort by perimeter.
            shapes = shapes.OrderBy(s => s.perimeter).ToList();
            Console.WriteLine("");
            Console.WriteLine("Sorted by perimeter:");
            shapes.ForEach(s => Console.WriteLine($"{s.name} Perimeter= {s.perimeter}"));
            Console.WriteLine("");

            ///Requirement 6.
            ///json.
            using (var shapesFile = System.IO.File.CreateText("shapes.json"))
            {
                shapes.ForEach(a => shapesFile.WriteLine(JsonConvert.SerializeObject(a)));
            }
            Console.WriteLine("shapes.json created");
            Console.WriteLine("");

            ///Requirement 7.
            ///number of Shape objects created.
            Console.WriteLine($"Circle: {shapes.Count(s => s is Circle).ToString()}");
            Console.WriteLine($"Triangle: {shapes.Count(s => s is Triangle).ToString()}");
            Console.WriteLine($"Quadrilateral: {shapes.Count(s => s is Quadrilateral).ToString()}");

            Console.ReadKey();
        }
    }
}
