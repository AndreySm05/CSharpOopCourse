namespace RangeTask;

internal class RangeTask
{
    public static void PrintRanges(Range[]? ranges)
    {
        if (ranges!.Length == 0)
        {
            Console.WriteLine("Пустое множество");
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < ranges.Length; i++)
        {
            Console.WriteLine($"Кусок {1 + i} - [{ranges[i].From}, {ranges[i].To}]");
            Console.WriteLine();
        }
    }
    static void Main()
    {
        // Первая часть задачи Range

        //Console.WriteLine("Введите начальное число диапазона:");

        //double startNumber = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Введите конечное число диапазона:");

        //double endNumber = Convert.ToDouble(Console.ReadLine());

        //Range range = new(startNumber, endNumber);

        //Console.WriteLine($"Длина введенного диапазона = {range.GetLength()}");

        //Console.WriteLine("Введите число для проверки принадлежности диапазону:");

        //double testNumber = Convert.ToDouble(Console.ReadLine());

        //if (range.IsInside(testNumber))
        //{
        //    Console.WriteLine("Число лежит в объявленном диапазоне");
        //}
        //else
        //{
        //    Console.WriteLine("Число не лежит в объявленном диапазоне");
        //}

        // Вторая часть задачи Range

        Range range1 = new Range(5, 20);
        Range range2 = new Range(10, 15);

        int i = 1;
        bool isFirstStart = true;

        while (range1.From - 2 <= range2.To)
        {
            Console.WriteLine($"Вариант проверки N{i}{Environment.NewLine}Первый отрезок - [{range1.From}, {range1.To}]{Environment.NewLine}" +
                $"Второй отрезок - [{range2.From}, {range2.To}]");
            Console.WriteLine();

            Console.WriteLine("Проверка операции ПЕРЕСЕЧЕНИЯ");

            if (range1.GetIntersection(range2) is null)
            {
                Console.WriteLine("Нет пересечений");
            }
            else
            {
                Range? intersectionRange = range1.GetIntersection(range2);
                Console.WriteLine($"Пересечение - [{intersectionRange!.From}, {intersectionRange.To}]");
            }

            Console.WriteLine();

            Console.WriteLine("Проверка операции ОБЪЕДИНЕНИЯ");
            PrintRanges(range1.GetUnion(range2));

            Console.WriteLine("Проверка операции РАЗНОСТИ");
            PrintRanges(range1.GetDifference(range2));

            i++;

            if (isFirstStart)
            {
                range1.To = 8;
                isFirstStart = false;
            }
            else
            {
                range1.From += 2;
                range1.To += 2;
            }
        }
    }
}