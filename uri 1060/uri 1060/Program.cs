using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x;
            x = 0;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            
           if (a > 0)
            {
                x += 1;
            }

            if (b > 0)
            {
                x += 1;
            }

            if (c > 0)
            {
                x += 1;
            }

            if (d > 0)
            {
                x += 1;
            }

            if (e > 0)
            {
                x += 1;
            }

            if (f > 0)
            {
                x += 1;
            }

            Console.WriteLine(x + " valores positivos");

        }
    }
}