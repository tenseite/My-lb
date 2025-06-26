using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "numbers.txt"; // Путь к файлу с числами
        double[] numbers = new double[12]; // Массив для хранения 12 чисел

        try
        {
            // Чтение всех строк из файла
            string[] lines = File.ReadAllLines(filePath);

            // Проверка количества чисел
            if (lines.Length < 12)
            {
                Console.WriteLine("Ошибка: В файле меньше 12 чисел");
                return;
            }

            // Заполнение массива
            for (int i = 0; i < 12; i++)
            {
                if (!double.TryParse(lines[i], out numbers[i]))
                {
                    Console.WriteLine($"Ошибка: Неверный формат числа в строке {i + 1}");
                    return;
                }
            }

            // Вывод массива для проверки
            Console.WriteLine("Считанные числа:");
            foreach (double num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Ошибка: Файл не найден");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
