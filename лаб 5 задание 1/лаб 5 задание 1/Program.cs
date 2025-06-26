using System;

class Program
{
    static void Main()
    {
        // Создаем массив вещественных чисел
        double[] numbers = { 3.5, -2.1, 0.0, -5.7, 4.2, -1.3, -0.8, 2.9 };

        // Инициализируем переменную для хранения минимального отрицательного элемента
        double minNegative = double.MaxValue;
        bool foundNegative = false;

        // Перебираем все элементы массива
        foreach (double num in numbers)
        {
            // Проверяем, является ли элемент отрицательным
            if (num < 0)
            {
                // Если это первый найденный отрицательный элемент или он меньше текущего минимума
                if (!foundNegative || num < minNegative)
                {
                    minNegative = num;
                    foundNegative = true;
                }
            }
        }

        // Выводим результат
        if (foundNegative)
        {
            Console.WriteLine($"Минимальный отрицательный элемент: {minNegative}");
        }
        else
        {
            Console.WriteLine("В массиве нет отрицательных элементов");
        }
    }
}
