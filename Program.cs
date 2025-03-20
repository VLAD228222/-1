namespace завдання__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дейко Влад
            Console.WriteLine("Дейко Влад");

            // Введення вартості булочки
            Console.Write("Введiть вартiсть булочки (гривнi): ");
            int hryvnias = int.Parse(Console.ReadLine());

            Console.Write("Введiть вартiсть булочки (копiйки): ");
            int kopecks = int.Parse(Console.ReadLine());

            // Введення кількості булочок
            Console.Write("Введiть кількiсть булочок: ");
            int quantity = int.Parse(Console.ReadLine());

            // Обчислення загальної вартості
            int totalKopecks = (hryvnias * 100 + kopecks) * quantity;
            int totalHryvnias = totalKopecks / 100;
            int remainingKopecks = totalKopecks % 100;

            // Виведення результату
            Console.WriteLine($"За {quantity} булочок необхiдно заплатити {totalHryvnias} гривень {remainingKopecks} копiйок.");
        }
    }
}
