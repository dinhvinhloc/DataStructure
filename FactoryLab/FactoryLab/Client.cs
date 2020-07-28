using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLab
{
    class Client
    {
        static void Main(string[] args)
        {
            Creator shapeFactory = new Creator();
            IShape rec1 = shapeFactory.FactoryMethod("Rectangle", 10.5);
            IShape rec2 = shapeFactory.FactoryMethod("Rectangle", new double[2] {12,13});

            IShape circle = shapeFactory.FactoryMethod("Circle", 20.1);
            IShape triangle1 = shapeFactory.FactoryMethod("Triangle", 11.1);
            IShape triangle2 = shapeFactory.FactoryMethod("Triangle", new double[2] { 12, 13 });

            Console.WriteLine(rec1.GetShapeName());
            Console.WriteLine(rec1.GetArea());
            Console.WriteLine(rec1.GetPerimeter());

            Console.WriteLine(rec2.GetShapeName());
            Console.WriteLine(rec2.GetArea());
            Console.WriteLine(rec2.GetPerimeter());

            Console.WriteLine(circle.GetShapeName());
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(circle.GetPerimeter());

            Console.WriteLine(triangle1.GetShapeName());
            Console.WriteLine(triangle1.GetArea());
            Console.WriteLine(triangle1.GetPerimeter());

            Console.WriteLine(triangle2.GetShapeName());
            Console.WriteLine(triangle2.GetArea());
            Console.WriteLine(triangle2.GetPerimeter());

            Console.ReadLine();
        }
    }
}
