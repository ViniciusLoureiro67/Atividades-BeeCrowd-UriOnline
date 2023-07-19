using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

           A = int.Parse(Console.ReadLine());
           B = int.Parse(Console.ReadLine());
           C = int.Parse(Console.ReadLine());
           D = int.Parse(Console.ReadLine());


            int DIFERENCA = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + DIFERENCA);










        }
    }
}