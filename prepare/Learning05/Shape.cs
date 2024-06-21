

using System.Diagnostics.Contracts;
using System.Drawing;

public abstract class Shape {
    protected string color = "";

    public Shape(string Color) {
        color = Color;
    }
    public string GetColor() {
        return color;
    }

    public void SetColor(string Color) {
        color = Color;
    }

    public abstract double GetArea();

}