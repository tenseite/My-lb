using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начало промежутка (a):");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите конец промежутка (b):");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите искомое количество делителей (k):");
        int k = int.Parse(Console.ReadLine());

        List<int> result = FindNumbersWithKDivisors(a, b, k);

        if (result.Count > 0)
        {
            Console.WriteLine($"Числа от {a} до {b} с {k} делителями:");
            Console.WriteLine(string.Join(", ", result));
        }
        else
        {
            Console.WriteLine($"В промежутке от {a} до {b} нет чисел с {k} делителями");
        }
    }

    static List<int> FindNumbersWithKDivisors(int a, int b, int k)
    {
        List<int> numbers = new List<int>();

        for (int num = a; num <= b; num++)
        {
            int divisorsCount = CountDivisors(num);
            if (divisorsCount == k)
            {
                numbers.Add(num);
            }
        }

        return numbers;
    }

    static int CountDivisors(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int count = 2; // 1 и само число n

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                if (i == n / i)
                {
                    count++;
                }
                else
                {
                    count += 2;
                }
            }
        }

        return count;
    }
}