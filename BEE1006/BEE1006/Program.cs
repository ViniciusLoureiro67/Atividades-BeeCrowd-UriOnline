using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, apeso, bpeso, cpeso, media;

            apeso = 2;
            bpeso = 3;
            cpeso = 5;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * apeso) + (B * bpeso) + (C * cpeso)) / 10.0;

                Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
         

        }
    }
}