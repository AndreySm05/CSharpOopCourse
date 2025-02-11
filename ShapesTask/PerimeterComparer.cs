namespace ShapesTask;

internal class PerimeterComparer : IComparer<IShape>
{
    public int Compare(IShape? shape1, IShape? shape2)
    {
        if (shape1 is null || shape2 is null)
        {
            throw new ArgumentException("Некорректное значение параметра");
        }

        return (int)Math.Round(shape1.GetPerimeter() - shape2!.GetPerimeter(), MidpointRounding.AwayFromZero);
    }
}