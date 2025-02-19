namespace ShapesTask;

public class Triangle : IShape
{
    public double X1 { get; set; }
    public double Y1 { get; set; }

    public double X2 { get; set; }
    public double Y2 { get; set; }

    public double X3 { get; set; }
    public double Y3 { get; set; }

    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
        X3 = x3;
        Y3 = y3;
    }

    public override string ToString()
    {
        return $"Координаты сторон треугольника ({X1}, {Y1}), ({X2}, {Y2}), ({X3}, {Y3})";
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

        Triangle triangle = (Triangle)obj;

        return X1 == triangle.X1 && Y1 == triangle.Y2 &&
               X2 == triangle.X2 && Y2 == triangle.Y2 &&
               X3 == triangle.X3 && Y3 == triangle.Y3;
    }

    public override int GetHashCode()
    {
        const int Prime = 17;
        int hash = 1;

        hash = Prime * hash + X1.GetHashCode();
        hash = Prime * hash + Y1.GetHashCode();
        hash = Prime * hash + X2.GetHashCode();
        hash = Prime * hash + Y2.GetHashCode();
        hash = Prime * hash + X3.GetHashCode();
        hash = Prime * hash + Y3.GetHashCode();

        return hash;
    }

    private double GetSideLength(double x1, double x2, double y1, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    private double[] GetSides()
    {
        return [GetSideLength(X1, X2, Y1, Y2), GetSideLength(X2, X3, Y2, Y3), GetSideLength(X1, X3, Y1, Y3)];
    }

    public double GetWidth()
    {
        return Math.Max(Math.Max(X1, X2), X3) - Math.Min(Math.Min(X1, X2), X3);
    }

    public double GetHeight()
    {
        return Math.Max(Math.Max(Y1, Y2), Y3) - Math.Min(Math.Min(Y1, Y2), Y3);
    }

    public double GetPerimeter()
    {
        double[] sides = GetSides();

        return sides[0] + sides[1] + sides[2];
    }

    public double GetArea()
    {
        double semiPerimeter = GetPerimeter() / 2;

        double[] sides = GetSides();

        return Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));
    }
}