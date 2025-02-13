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

        Circle circle = (Circle)obj;

        return Radius == circle.Radius;
    }

    public override int GetHashCode()
    {
        int prime = 23;
        int hash = 1;

        hash = prime * hash + Radius.GetHashCode();

        return hash;
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