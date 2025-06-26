using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 5, 8, 3, 1 },
            { 4, 7, 6, 2 },
            { 9, 0, 2, 5 }
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortColumns(matrix);

        Console.WriteLine("\nОтсортированная матрица:");
        PrintMatrix(matrix);
    }

    static void SortColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            int[] column = new int[rows];

            // Копируем столбец в массив
            for (int i = 0; i < rows; i++)
                column[i] = matrix[i, j];

            // Сортируем в зависимости от чётности столбца
            if (j % 2 == 0) // Чётный столбец → по убыванию
                QuickSort(ref column, 0, rows - 1, descending: true);
            else             // Нечётный столбец → по возрастанию
                QuickSort(ref column, 0, rows - 1, descending: false);

            // Возвращаем отсортированный столбец в матрицу
            for (int i = 0; i < rows; i++)
                matrix[i, j] = column[i];
        }
    }

    static void QuickSort(ref int[] arr, int low, int high, bool descending)
    {
        if (low < high)
        {
            int pivotIndex = Partition(ref arr, low, high, descending);
            QuickSort(ref arr, low, pivotIndex - 1, descending);
            QuickSort(ref arr, pivotIndex + 1, high, descending);
        }
    }

    static int Partition(ref int[] arr, int low, int high, bool descending)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            bool condition = descending ? arr[j] >= pivot : arr[j] <= pivot;
            if (condition)
            {
                i++;
                Swap(ref arr[i], ref arr[j]);
            }
        }

        Swap(ref arr[i + 1], ref arr[high]);
        return i + 1;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }
}