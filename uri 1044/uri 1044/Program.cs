using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            string[] numero = Console.ReadLine().Split(' ');

            int A = int.Parse(numero[0]);
            int B = int.Parse(numero[1]);

            if (A % B == 0 || B % A == 0)
            {
             
                Console.WriteLine("Sao Multiplos");

            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}