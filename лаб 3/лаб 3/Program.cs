using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начало диапазона (A):");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите конец диапазона (B):");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine("\nЧетные числа, кратные 5 (while):");
        int current = A;
        while (current <= B)
        {
            if (current % 10 == 0)  // Числа, кратные 10 (четные и кратные 5)
            {
                Console.Write(current + " ");
            }
            current++;
        }
    }
}