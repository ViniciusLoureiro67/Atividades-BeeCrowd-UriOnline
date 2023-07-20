using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');

            double a = double.Parse(valor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valor[2], CultureInfo.InvariantCulture);

            // area = (base maior + base menor) multiplicar pela altura e dividir por dois
            // ((a + b) * c) / 2

            if (a < b + c && b < a + c && c < a + b)
            {
                double perimetro = a + b + c;
                    Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));

            }
            else
            {
                    double area = ((a + b) * c) / 2;
                    Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));  
            }

        }
    }
}