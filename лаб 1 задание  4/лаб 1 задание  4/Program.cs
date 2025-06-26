using System;

class Program
{
    static void Main()
    {
        // Прейскурант цен на велосипеды (можно расширить)
        double[] bikePrices = { 15000, 22000, 18500, 30000, 12500, 27500 };

        Console.WriteLine("Введите сумму денег у покупателя:");
        double customerMoney = double.Parse(Console.ReadLine());

        bool foundBike = false;

        // Проверяем каждый велосипед в прейскуранте
        foreach (double price in bikePrices)
        {
            if (price <= customerMoney)
            {
                foundBike = true;
                Console.WriteLine($"Можно купить велосипед за {price} руб.");
            }
        }

        if (!foundBike)
        {
            Console.WriteLine("Нет доступных велосипедов по вашей сумме");
        }
    }
}