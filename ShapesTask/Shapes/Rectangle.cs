namespace ShapesTask;

internal class Rectangle : IShape
{
    public double Width { get; set; }

    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString()
    {
        return $"Первая сторона прямоугольника = {Width}, вторая сторона прямоугольника = {Height}";
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

        return Width == rectangle.Width && Height == rectangle.Height;
    }

    public override int GetHashCode()
    {
        const int Prime = 13;
        int hash = 1;

        hash = Prime * hash + Width.GetHashCode();
        hash = Prime * hash + Height.GetHashCode();

        return hash;
    }

    public double GetWidth()
    {
        return Width;
    }

    public double GetHeight()
    {
        return Height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return (Width + Height) * 2.0;
    }
}