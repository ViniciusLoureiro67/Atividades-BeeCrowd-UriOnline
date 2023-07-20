using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x, y;
            x = 0;
            y = 0;

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a > 0)
            {
                x += 1;
                y += a;
            }

            if (b > 0)
            {
                x += 1;
                y += b;
            }

            if (c > 0)
            {
                x += 1;
                y += c;
            }

            if (d > 0)
            {
                x += 1;
                y += d;
            }

            if (e > 0)
            {
                x += 1;
                y += e;
            }

            if (f > 0)
            {
                x += 1;
                y += f;
            }

            Console.WriteLine(x + " valores positivos");
            double media = y / x;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}