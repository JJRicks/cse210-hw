using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection.Metadata;

public class Rectangle : Shape {

    public double length { get; set; } = 0.0D;
    public double width { get; set; } = 0.0D;

    public Rectangle(string Color, double Length, double Width) : base(Color) {
        color = Color;
        length = Length;
        width = Width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}