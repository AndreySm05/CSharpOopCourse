namespace ShapesTask;

internal class ShapesTask
{
    public static IShape GetMaxAreaShape(IShape[] shapes)
    {
        Array.Sort(shapes, new ShapesAreaComparer());

        return shapes[^1];
    }

    public static IShape GetPreMaxPerimeterShape(IShape[] shapes)
    {
        Array.Sort(shapes, new ShapesPerimeterComparer());

        return shapes[^2];
    }

    static void Main()
    {
        IShape[] shapes =
        [
            new Square(10), new Triangle(10, 13, 55, 65, 1, 4),
            new Rectangle(10, 20), new Circle(4),
            new Square(5), new Triangle(10, 13, 55, 85, 5, 8),
            new Square(15), new Circle(100)
        ];

        // Проверка сортировки по площади
        IShape maxAreaShape = GetMaxAreaShape(shapes);

        Console.WriteLine($"Данные фигуры: {maxAreaShape.ToString()}");
        Console.WriteLine($"Площадь = {maxAreaShape.GetArea()}");
        Console.WriteLine($"Периметр = {maxAreaShape.GetPerimeter()}");
        Console.WriteLine($"Ширина = {maxAreaShape.GetWidth()}");
        Console.WriteLine($"Высота = {maxAreaShape.GetHeight()}");

        Console.WriteLine();

        // Проверка сортировки по периметру
        IShape preMaxPerimeterShape = GetPreMaxPerimeterShape(shapes);

        Console.WriteLine($"Данные фигуры: {preMaxPerimeterShape.ToString()}");
        Console.WriteLine($"Площадь = {preMaxPerimeterShape.GetArea()}");
        Console.WriteLine($"Периметр = {preMaxPerimeterShape.GetPerimeter()}");
        Console.WriteLine($"Ширина = {preMaxPerimeterShape.GetWidth()}");
        Console.WriteLine($"Высота = {preMaxPerimeterShape.GetHeight()}");

        Triangle rec1 = new Triangle(10, 13, 55, 65, 1, 4);
        Triangle rec2 = new Triangle(10, 12, 55, 65, 1, 4);

        Console.WriteLine(rec1.GetHashCode());
        Console.WriteLine(rec2.GetHashCode());
    }
}