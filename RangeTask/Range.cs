namespace RangeTask;

public class Range
{
    public double From { get; set; }

    public double To { get; set; }

    public Range(double from, double to)
    {
        From = from;
        To = to;
    }

    public double GetLength()
    {
        return To - From;
    }

    public bool IsInside(double number)
    {
        return number >= From && number <= To;
    }

    public Range? GetIntersection(Range range)
    {
        if (To <= range.From || From >= range.To)
        {
            return null;
        }

        return new Range(Math.Max(From, range.From), Math.Min(To, range.To));
    }

    public Range[] GetUnion(Range range)
    {
        if (To < range.From || From > range.To)
        {
            return [new Range(From, To), new Range(range.From, range.To)];
        }

        return [new Range(Math.Min(From, range.From), Math.Max(To, range.To))];
    }

    public Range[]? GetDifference(Range range)
    {
        // Отрезки не пересекаются
        if (To <= range.From || From >= range.To)
        {
            return [new Range(From, To)];
        }

        // Второй отрезок полностью содержит первый или равен ему
        if (From >= range.From && To <= range.To)
        {
            return []; // пустое множество
        }

        // Второй отрезок полностью входит в первый
        if (From < range.From && To > range.To)
        {
            return [new Range(From, range.From), new Range(range.To, To)];
        }

        // Пересекается правая часть отрезка
        if (From < range.From)
        {
            return [new Range(From, range.From)];
        }

        return [new Range(range.To, To)];
    }
}