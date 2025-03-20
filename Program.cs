
using System;

namespace Влад_Дейко
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deiko");
            double a, x, y; a = 10;
            x = 12.5 * a;
            y = 8.5 * x + (9 + 3  * a) / (a + 1);
            Console.WriteLine($"a={a} ,x={x},y={y}");    
            double Y = Math.Sqrt(y);
            double X = Math.Pow(x, a);
            Console.WriteLine($"корінь із y={Y}");
            Console.WriteLine($"x в степени a = {X}");
        }
    }
}
