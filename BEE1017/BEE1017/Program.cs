using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade;
            double qlitros, kml;

            kml = 12;
            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());


            qlitros = (tempo*velocidade/kml);

            Console.WriteLine(qlitros.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}