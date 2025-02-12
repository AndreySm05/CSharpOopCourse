using System.Security.Cryptography;

namespace ShapesTask;

internal class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override string ToString()
    {
        return ($"Радиус окружности = {Radius}");
    }

    public double GetWidth()
    {
        return 2 * Radius;
    }

    public double GetHeight()
    {
        return 2 * Radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}