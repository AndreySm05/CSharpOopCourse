namespace RangeTask;

internal class RangeTask
{
    public static void PrintIntervals(Range[]? range)
    {
        if (range is null)
        {
            Console.WriteLine("Пустое множество");
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < range.Length; i++)
        {
            Console.WriteLine($"Кусок {1 + i} - [{range[i].From}, {range[i].To}]");
            Console.WriteLine();
        }
    }
    static void Main()
    {
        //Первая часть задачи Range
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
        bool firstStart = true;

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
                Range? range3 = range1.GetIntersection(range2);
                Console.WriteLine($"Пересечение - [{range3!.From}, {range3.To}]");
            }

            Console.WriteLine();

            Console.WriteLine("Проверка операции ОБЪЕДИНЕНИЯ");
            PrintIntervals(range1.GetUnion(range2));

            Console.WriteLine("Проверка операции РАЗНОСТИ");
            PrintIntervals(range1.GetComplement(range2));

            if (firstStart)
            {
                range1.To = 8;
                firstStart = false;
            }
            else
            {
                range1.From += 2;
                range1.To += 2;
            }
        }
    }
}