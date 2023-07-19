using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');
            double x = double.Parse(valor[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valor[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }

            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }

            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }

            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }

            else if ( x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");
                }
 
        }
    }
}