namespace ShapesTask;

internal class ShapeAreaComparer : IComparer<IShape>
{
    public int Compare(IShape? shape1, IShape? shape2)
    {
        if (shape1 is null || shape2 is null)
        {
            if (shape1 is null)
            {
                throw new ArgumentNullException(nameof(shape1), "Фигура не может быть null");
            }

            throw new ArgumentNullException(nameof(shape2), "Фигура не может быть null");
        }

        return shape1.GetArea().CompareTo(shape2.GetArea());
    }
}