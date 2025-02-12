using System.Security.Cryptography;

namespace ShapesTask;

internal class Square : IShape
{
    public double Length { get; set; }

    public Square(double lenght)
    {
        Length = lenght;
    }

    public override string ToString()
    {
        return ($"Сторона квадрата = {Length}");
    }

    public double GetWidth()
    {
        return Length;
    }

    public double GetHeight()
    {
        return Length;
    }

    public double GetArea()
    {
        return Length * Length;
    }

    public double GetPerimeter()
    {
        return Length * 4.0;
    }
}