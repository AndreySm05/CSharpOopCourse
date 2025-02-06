namespace ShapesTask;

internal class Rectangle
{
    public double Side1Lenght { get; set; }

    public double Side2Lenght { get; set; }

    public Rectangle(double side1Lenght, double side2Lenght)
    {
        Side1Lenght = side1Lenght;
        Side2Lenght = side2Lenght;
    }

    public double GetWidth()
    {
        return Math.Max(Side1Lenght, Side2Lenght);
    }

    public double GetHeight()
    {
        return Math.Min(Side1Lenght, Side2Lenght);
    }

    public double GetArea()
    {
        return Side1Lenght * Side2Lenght;
    }

    public double GetPerimeter()
    {
        return (Side1Lenght + Side2Lenght) * 2.0;
    }
}