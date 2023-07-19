using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double A, B, C, areaquadrado, arearetangulo, areatriangulo, pi, raioquadrado, areacirculo, areatrapezio;

            pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            raioquadrado = Math.Pow(C, 2);
            areatriangulo = (A * C) / 2;
            areacirculo = pi * raioquadrado;
            areatrapezio = ((A + B) * C) / 2;
            areaquadrado = Math.Pow(B, 2);
            arearetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areatriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areacirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areatrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaquadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + arearetangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}