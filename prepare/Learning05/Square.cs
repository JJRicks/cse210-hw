using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape {
    public double side { get; set; }
    
    public Square(string Color, double Side) : base(Color) {
        color = Color;
        side = Side;
    }

    public override double GetArea()
    {
        return side * side;
    }
}