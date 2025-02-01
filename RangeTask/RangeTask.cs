namespace RangeTask
{
    internal class RangeTask

    {
        static void Main()
        {
            Console.WriteLine("Введите начальное число диапазона:");
            double startNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите конечное число диапазона:");
            double endNumber = Convert.ToDouble(Console.ReadLine());

            Range range = new(startNumber, endNumber);
            Console.WriteLine($"Длина введенного диапазона = {range.GetLength()}");

            Console.WriteLine("Введите число для проверки принадлежности диапазону:");
            double testNumber = Convert.ToDouble(Console.ReadLine());

            if (range.IsInside(testNumber))
            {
                Console.WriteLine("Число лежит в объявленном диапазоне");
            }
            else
            {
                Console.WriteLine("Число не лежит в объявленном диапазоне");
            }
        }
    }
}