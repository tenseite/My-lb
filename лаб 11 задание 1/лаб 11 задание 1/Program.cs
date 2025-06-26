using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Укажите путь к вашему текстовому файлу
        string filePath = "path/to/your/file.txt";

        // Запрашиваем у пользователя номер символа (индекс)
        Console.Write("Введите номер символа (k): ");
        if (!int.TryParse(Console.ReadLine(), out int k) || k < 1)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
            return;
        }

        // Считываем файл и формируем слово
        string result = string.Empty;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Проверяем, что строка достаточно длинная
                    if (line.Length >= k)
                    {
                        // Добавляем символ с индексом k-1 (так как индексация начинается с 0)
                        result += line[k - 1];
                    }
                }
            }

            Console.WriteLine($"Слово, образованное символами с номером {k}: {result}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден. Проверьте путь к файлу.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
