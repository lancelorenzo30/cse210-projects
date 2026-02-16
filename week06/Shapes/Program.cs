using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();


        Square s1 = new Square("blue", 5);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("green", 3, 4);
        shapes.Add(r1);

        Circle c1 = new Circle("bluegreen", 6);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}