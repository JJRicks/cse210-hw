using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapeList = new List<Shape>();
        
        Square square = new Square("blue", 4.0);

        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("yellow", 2.0, 4.0);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("red", 2);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());    

        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach(Shape shape in shapeList) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}