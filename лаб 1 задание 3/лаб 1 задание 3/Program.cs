using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координату x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координату y:");
        double y = double.Parse(Console.ReadLine());

        // Проверяем положение точки относительно границ
        bool onBorder = (y == -x) || (y == x) || (y == 0);
        bool insideArea = (y > -x) && (y < x) && (y > 0);

        if (onBorder)
        {
            Console.WriteLine("На границе");
        }
        else if (insideArea)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}