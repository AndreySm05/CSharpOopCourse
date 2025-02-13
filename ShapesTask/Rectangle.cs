namespace ShapesTask;

internal class Rectangle : IShape
{
    public double Side1Length { get; set; }

    public double Side2Length { get; set; }

    public Rectangle(double side1Lenght, double side2Lenght)
    {
        Side1Length = side1Lenght;
        Side2Length = side2Lenght;
    }

    public override string ToString()
    {
        return ($"Первая сторона прямоугольника = {Side1Length} {Environment.NewLine}" +
            $"Вторая сторона прямоугольника = {Side2Length}");
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

        Rectangle rectangle = (Rectangle)obj;

        return Side1Length == rectangle.Side1Length && Side2Length == rectangle.Side2Length;
    }

    public double GetWidth()
    {
        return Math.Max(Side1Length, Side2Length);
    }

    public double GetHeight()
    {
        return Math.Min(Side1Length, Side2Length);
    }

    public double GetArea()
    {
        return Side1Length * Side2Length;
    }

    public double GetPerimeter()
    {
        return (Side1Length + Side2Length) * 2.0;
    }
}