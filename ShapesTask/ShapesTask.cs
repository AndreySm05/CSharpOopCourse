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
        IShape shape1 = GetMaxArea(shapes);

        string? shape1Name = shape1.ToString().Substring(shape1.ToString().IndexOf(".") + 1);

        Console.WriteLine($"Вид фигуры = {shape1Name}");
        Console.WriteLine($"Площадь = {shape1.GetArea()}");
        Console.WriteLine($"Периметр = {shape1.GetPerimeter()}");
        Console.WriteLine($"Ширина = {shape1.GetWidth()}");
        Console.WriteLine($"Высота = {shape1.GetHeight()}");

        Console.WriteLine();

        // Проверка сортировки по периметру
        IShape shape2 = GetPreMaxPerimeter(shapes);

        string? shape2Name = shape2.ToString().Substring(shape2.ToString().IndexOf(".") + 1);

        Console.WriteLine($"Вид фигуры = {shape2Name}");
        Console.WriteLine($"Площадь = {shape2.GetArea()}");
        Console.WriteLine($"Периметр = {shape2.GetPerimeter()}");
        Console.WriteLine($"Ширина = {shape2.GetWidth()}");
        Console.WriteLine($"Высота = {shape2.GetHeight()}");
    }
}