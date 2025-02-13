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

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(obj, this))
        {
            return true;
        }

        if (ReferenceEquals(obj, null) || obj.GetType() != GetType())
        {
            return false;
        }

        Square square = (Square)obj;

        return Length == square.Length;
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