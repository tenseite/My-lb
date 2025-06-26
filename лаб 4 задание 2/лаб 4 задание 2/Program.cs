using System;

class SalesAnalysis
{
    static void Main()
    {
        // Инициализация данных
        int[,] quantities = new int[5, 6]; // 5 видов товара, 6 дней
        double[] prices = new double[5];    // Цены на товары
        double[,] dailyRevenue = new double[5, 6]; // Доход по товарам за дни
        double[] productTotal = new double[5];     // Итог по товарам
        double[] dayTotal = new double[6];         // Итог по дням

        // Ввод цен на товары
        Console.WriteLine("Введите цены для 5 видов товаров:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Товар {i + 1}: ");
            prices[i] = double.Parse(Console.ReadLine());
        }

        // Ввод количества проданных товаров
        Console.WriteLine("\nВведите количество проданных товаров:");
        for (int day = 0; day < 6; day++)
        {
            Console.WriteLine($"\nДень {day + 1}:");
            for (int product = 0; product < 5; product++)
            {
                Console.Write($"Товар {product + 1}: ");
                quantities[product, day] = int.Parse(Console.ReadLine());

                // Рассчитываем доход
                dailyRevenue[product, day] = quantities[product, day] * prices[product];
            }
        }

        // Вывод таблицы продаж
        Console.WriteLine("\nТаблица продаж:");
        Console.Write("Товар\\День\t");
        for (int day = 0; day < 6; day++)
            Console.Write($"День {day + 1}\t");
        Console.WriteLine();

        for (int product = 0; product < 5; product++)
        {
            Console.Write($"Товар {product + 1} ({prices[product]} руб.)\t");
            for (int day = 0; day < 6; day++)
            {
                Console.Write($"{quantities[product, day]}\t");
            }
            Console.WriteLine();
        }

        // Расчет общего дохода по товарам
        Console.WriteLine("\nОбщий доход по товарам:");
        for (int product = 0; product < 5; product++)
        {
            for (int day = 0; day < 6; day++)
            {
                productTotal[product] += dailyRevenue[product, day];
            }
            Console.WriteLine($"Товар {product + 1}: {productTotal[product]} руб.");
        }

        // Расчет общего дохода по дням
        Console.WriteLine("\nОбщий доход по дням:");
        for (int day = 0; day < 6; day++)
        {
            for (int product = 0; product < 5; product++)
            {
                dayTotal[day] += dailyRevenue[product, day];
            }
            Console.WriteLine($"День {day + 1}: {dayTotal[day]} руб.");
        }
    }
}