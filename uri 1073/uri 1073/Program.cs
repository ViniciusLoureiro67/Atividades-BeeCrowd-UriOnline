using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            int N = int.Parse(Console.ReadLine());

         
            for (int i = 2; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "^" + "2 = ");
                    int quadrado = i * i;
                    Console.WriteLine(quadrado);
                }


            }

        }
    }
}