using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x1, x2, y1, y2, distancia, pp, pp2;

            string[] valores = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);



            string[] valores2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores2[1], CultureInfo.InvariantCulture);

            pp = Math.Pow((x2 - x1), 2);
            pp2 = Math.Pow((y2 - y1), 2);


            distancia = Math.Sqrt(pp + pp2);

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}