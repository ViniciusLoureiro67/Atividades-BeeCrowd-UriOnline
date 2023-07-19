using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, h,resto, minutos, segundos;
            // 1h = 60m = 3600m

            N = int.Parse(Console.ReadLine());

            h = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;


            Console.WriteLine(h + ":" + minutos + ":" + segundos);




        }
    }
}