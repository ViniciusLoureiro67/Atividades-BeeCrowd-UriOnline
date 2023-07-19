using System;
using System.Globalization;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //area = π . raio2
            // π = 3.14159:
            //Efetue o cálculo da área, elevando o valor de raio 
            //ao quadrado e multiplicando por π

            // r = raio
            // C = Raio²

            double n = 3.14159;

            double r = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double C = Math.Pow(r, 2);

            double A = n * C;

            Console.Write("A=");
            Console.WriteLine(A.ToString("F4", CultureInfo.InvariantCulture));




        }
    }
}