using System;

class ChineseZodiac
{
    static void Main()
    {
        Console.WriteLine("Введите год:");
        int year = int.Parse(Console.ReadLine());

        // Восточный календарь имеет 12-летний цикл
        int zodiacIndex = (year - 4) % 12;

        // Определяем животное по индексу
        string animal;
        switch (zodiacIndex)
        {
            case 0:
                animal = "Крыса";
                break;
            case 1:
                animal = "Бык";
                break;
            case 2:
                animal = "Тигр";
                break;
            case 3:
                animal = "Кролик";
                break;
            case 4:
                animal = "Дракон";
                break;
            case 5:
                animal = "Змея";
                break;
            case 6:
                animal = "Лошадь";
                break;
            case 7:
                animal = "Коза";
                break;
            case 8:
                animal = "Обезьяна";
                break;
            case 9:
                animal = "Петух";
                break;
            case 10:
                animal = "Собака";
                break;
            case 11:
                animal = "Свинья";
                break;
            default:
                animal = "Неизвестно";
                break;
        }

        Console.WriteLine($"{year} год - год {animal} по восточному календарю");
    }
}