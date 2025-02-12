namespace ShapesTask;

internal class ShapesTask
{
    public static IShape GetMaxArea(IShape[] shapes)
    {
        Array.Sort(shapes, new AreaComparer());

        return shapes[shapes.Length - 1];
    }

    public static IShape GetPreMaxPerimeter(IShape[] shapes)
    {
        Array.Sort(shapes, new PerimeterComparer());

        return shapes[shapes.Length - 2];
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
        IShape maxAreaShape = GetMaxArea(shapes);

        Console.WriteLine($"Данные фигуры: {maxAreaShape.ToString()}");
        Console.WriteLine($"Площадь = {maxAreaShape.GetArea()}");
        Console.WriteLine($"Периметр = {maxAreaShape.GetPerimeter()}");
        Console.WriteLine($"Ширина = {maxAreaShape.GetWidth()}");
        Console.WriteLine($"Высота = {maxAreaShape.GetHeight()}");

        Console.WriteLine();

        // Проверка сортировки по периметру
        IShape preMaxPerimeterShape = GetPreMaxPerimeter(shapes);

        Console.WriteLine($"Данные фигуры: {preMaxPerimeterShape.ToString()}");
        Console.WriteLine($"Площадь = {preMaxPerimeterShape.GetArea()}");
        Console.WriteLine($"Периметр = {preMaxPerimeterShape.GetPerimeter()}");
        Console.WriteLine($"Ширина = {preMaxPerimeterShape.GetWidth()}");
        Console.WriteLine($"Высота = {preMaxPerimeterShape.GetHeight()}");
    }
}