using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, apeso, bpeso, media;

            apeso = 3.50000;
            bpeso = 7.50000;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (A*apeso + B * bpeso) / 11.00000; 

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));







        }
    }
}