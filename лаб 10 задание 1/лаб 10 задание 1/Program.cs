using System;

class Program
{
    static void Main()
    {
        // Исходный массив
        double[] array = { 1.2, 3.4, 5.6, 7.8, 9.0, 11.2, 13.4 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Обработка массива
        ProcessArray(array);

        Console.WriteLine("\nМассив после обработки:");
        PrintArray(array);
    }

    static void ProcessArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            // Проверяем, является ли индекс нечётным (нумерация с 0)
            if (i % 2 != 0)
            {
                // Заменяем элемент на его квадратный корень
                array[i] = Math.Sqrt(array[i]);
            }
        }
    }

    static void PrintArray(double[] array)
    {
        foreach (double num in array)
        {
            Console.Write($"{num:F4} "); // Выводим с 4 знаками после запятой
        }
        Console.WriteLine();
    }
}