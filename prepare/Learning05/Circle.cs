public class Circle : Shape {
    
    public double radius { get; set; } = 0.0D;

    public Circle(string Color, double Radius) : base(Color) {
        color = Color;
        radius = Radius;
    }

    public override double GetArea()
    {
        return 2 * 3.14159 * radius;
    }
}