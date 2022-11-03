// Lab_05_5.cs
// Якубовський Владислав
// Лабораторна робота № 5.4 
// Рекурсивні функції.
// Варіант 24
using System;
using static System.Math;

namespace AP_Lab_05_5
{
    public class Lab_05_5
    {
        public static double F(double n, double r, double k, int ii, int level, ref int depth)
        {
            if (level > depth)
                depth = level;

            Console.WriteLine($"<рівень рекурсії: {level}>");

            if (n == 0 && r == 0)
                return 1;

            else if (n > 0 && r >= 0 && r <= n * (k - 1) + 1)
                return F(n - 1, r - 1, k, ii + 1, level + 1, ref depth);

            else return 0;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            int depth = 0;

            Random randomVar = new Random();            

            Console.Write("Введіть значення змінних \"n\", \"k\" по черзі через крапку з комою: ");            

            string[] varArray = Console.ReadLine().Split(';');

            double n = Double.Parse(varArray[0].Replace('.', ',')),
                k = Double.Parse(varArray[1].Replace('.', ',')),
                x = 0,
                t = randomVar.Next(0, 11),
                m = Pow(10, t);

            for (int ii = 0; ii < n * (k - 1); ii++)
                x += F(n, ii, k, 0, 1, ref depth) % m;

            Console.WriteLine($"Отримане значення \"x\":\t{x}\n" +
                $"Глибина рекурсії:\t{depth}");

            Console.ReadLine();
        }
    }
}
