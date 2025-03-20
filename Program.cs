using System;

namespace завдання;
    class Program
    {
        static void Main(string[] args)
        {
        // Дейко Влад
        Console.WriteLine("Дейко Влад");

        // Введення кількості хвилин
        Console.Write("Введiть кiлькiсть хвилин: ");
        int totalMinutes = int.Parse(Console.ReadLine());

        // Обчислення годин та хвилин
        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;

        // Вивід результату у форматі години:хвилини
        Console.WriteLine($"Результат: {hours:D2}:{minutes:D2}");
    }
    }

