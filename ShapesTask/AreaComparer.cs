namespace ShapesTask;

internal class AreaComparer : IComparer<IShape>
{
    public int Compare(IShape? shape1, IShape? shape2)
    {
        if (shape1 is null || shape2 is null)
        {
            throw new ArgumentException("Некорректное значение параметра");
        }

        return (int)Math.Round(shape1.GetArea() - shape2!.GetArea(), MidpointRounding.AwayFromZero);
    }
}