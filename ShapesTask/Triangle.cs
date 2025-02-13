﻿namespace ShapesTask;

internal class Triangle : IShape
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
        return ($"Координаты сторон треугольника ({X1},{Y1}), ({X2},{Y2}), ({X3},{Y3})");
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
        int prime = 17;
        int hash = 1;

        hash = prime * hash + X1.GetHashCode();
        hash = prime * hash + Y1.GetHashCode();
        hash = prime * hash + X2.GetHashCode();
        hash = prime * hash + Y2.GetHashCode();
        hash = prime * hash + X3.GetHashCode();
        hash = prime * hash + Y3.GetHashCode();

        return hash;
    }

    public double[] GetSides()
    {
        double side1Length = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        double side2Length = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
        double side3Length = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));

        return [side1Length, side2Length, side3Length];
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
        return GetSides()[0] + GetSides()[1] + GetSides()[2];
    }

    public double GetArea()
    {
        double semiPerimeter = GetPerimeter() / 2;

        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - GetSides()[0]) * (semiPerimeter - GetSides()[1]) * (semiPerimeter - GetSides()[2]));

        return area;
    }
}