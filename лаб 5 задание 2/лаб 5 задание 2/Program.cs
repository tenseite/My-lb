using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива:");
        int n = int.Parse(Console.ReadLine());

        double[] array = new double[n];

        Console.WriteLine($"Введите {n} вещественных чисел:");
        for (int i = 0; i < n; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        // Поиск индексов первого и второго отрицательных элементов
        int firstNegativeIndex = -1;
        int secondNegativeIndex = -1;

        for (int i = 0; i < n; i++)
        {
            if (array[i] < 0)
            {
                if (firstNegativeIndex == -1)
                {
                    firstNegativeIndex = i;
                }
                else if (secondNegativeIndex == -1)
                {
                    secondNegativeIndex = i;
                    break; // Нашли второй отрицательный - выходим из цикла
                }
            }
        }

        // Вычисление суммы между первым и вторым отрицательными элементами
        double sum = 0;

        if (firstNegativeIndex != -1 && secondNegativeIndex != -1)
        {
            Console.WriteLine($"\nПервый отрицательный элемент: array[{firstNegativeIndex}] = {array[firstNegativeIndex]}");
            Console.WriteLine($"Второй отрицательный элемент: array[{secondNegativeIndex}] = {array[secondNegativeIndex]}");

            // Суммируем элементы между ними (не включая сами отрицательные элементы)
            for (int i = firstNegativeIndex + 1; i < secondNegativeIndex; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"\nСумма элементов между первым и вторым отрицательными элементами: {sum}");
        }
        else
        {
            Console.WriteLine("\nВ массиве недостаточно отрицательных элементов для вычисления суммы");
        }
    }
}