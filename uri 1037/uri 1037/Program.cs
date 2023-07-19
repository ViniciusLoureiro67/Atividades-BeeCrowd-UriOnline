using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0.0000 && numero <= 25.0000000)
            {
                Console.WriteLine("Intervalo [0,25]");

            }
            else if (numero > 25.0000000  && numero <= 50.0000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
             else if (numero > 50.000000 && numero <= 75.00000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (numero > 75.0000000 && numero <= 100.00000000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}