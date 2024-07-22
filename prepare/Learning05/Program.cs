using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = [];

        Square square = new Square("blue", 2.0);
        Rectangle rectangle = new Rectangle("red", 2.0, 4.0);
        Circle circle = new Circle("orange", 3.0);

        list.Add(square);
        list.Add(rectangle);
        list.Add(circle);

        foreach (Shape shape in list)
        {
            Console.WriteLine($"{shape.GetColor()}");
            Console.WriteLine($"{shape.GetArea()}");
        }
    }
}