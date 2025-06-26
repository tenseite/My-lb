using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[8, 8];
        Random rnd = new Random();

        // Заполнение матрицы случайными числами от 0 до 99
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                A[i, j] = rnd.Next(100);
            }
        }

        // Вывод матрицы
        Console.WriteLine("Матрица A:");
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(A[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }

        // Поиск минимального элемента и его порядкового номера
        int minValue = A[0, 0];
        int minIndex = 1; // порядковый номер начинается с 1

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                int currentIndex = i * 8 + j + 1;
                if (A[i, j] < minValue)
                {
                    minValue = A[i, j];
                    minIndex = currentIndex;
                }
            }
        }

        Console.WriteLine($"\nМинимальный элемент: {minValue}");
        Console.WriteLine($"Порядковый номер минимального элемента: {minIndex}");
    }
}