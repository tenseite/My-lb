using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 9, 0, 6, 1 },
            { 5, 7, 3, 2 },
            { 4, 8, 2, 5 }
        };

        // Часть (а): Найти минимальную строку с положительными элементами
        int minPositiveRow = -1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool allPositive = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] <= 0)
                {
                    allPositive = false;
                    break;
                }
            }
            if (allPositive)
            {
                minPositiveRow = i + 1; // Нумерация с 1
                break;
            }
        }
        Console.WriteLine($"а) Минимальный номер строки с положительными элементами: {minPositiveRow}");

        // Часть (б): Проверить каждый столбец на нечётные элементы
        Console.WriteLine("б) Наличие нечётных элементов в столбцах:");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            bool hasOdd = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] % 2 != 0)
                {
                    hasOdd = true;
                    break;
                }
            }
            Console.WriteLine($"Столбец {j + 1}: {(hasOdd ? "Да" : "Нет")}");
        }
    }
}