using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');

            int A = int.Parse(valor[0]);
            int B = int.Parse(valor[1]);
            int C = int.Parse(valor[2]);

            if (A < B && B < C)
            {
                Console.WriteLine(A);
                Console.WriteLine(B);
                Console.WriteLine(C);
                Console.WriteLine();
                Console.WriteLine(valor[0]);
                Console.WriteLine(valor[1]);
                Console.WriteLine(valor[2]);
            }
            else if (A < C && C < B)
            {
                Console.WriteLine(A);
                Console.WriteLine(C);
                Console.WriteLine(B);
                Console.WriteLine();
                Console.WriteLine(valor[0]);
                Console.WriteLine(valor[1]);
                Console.WriteLine(valor[2]);
            }
            else if (B < A && A < C)
            {
                Console.WriteLine(B);
                Console.WriteLine(A);
                Console.WriteLine(C);
                Console.WriteLine();
                Console.WriteLine(valor[0]);
                Console.WriteLine(valor[1]);
                Console.WriteLine(valor[2]);
            }
            else if (B < C && C < A)
            {
                Console.WriteLine(B);
                Console.WriteLine(C);
                Console.WriteLine(A);
                Console.WriteLine();
                Console.WriteLine(valor[0]);
                Console.WriteLine(valor[1]);
                Console.WriteLine(valor[2]);
            }
            else if (C < A && A < B)
            {
                Console.WriteLine(C);
                Console.WriteLine(A);
                Console.WriteLine(B);
                Console.WriteLine();
                Console.WriteLine(valor[0]);
                Console.WriteLine(valor[1]);
                Console.WriteLine(valor[2]);
            }
            else
            {
                Console.WriteLine(C);
                Console.WriteLine(B);
                Console.WriteLine(A);
                Console.WriteLine();
                Console.WriteLine(valor[0]);
                Console.WriteLine(valor[1]);
                Console.WriteLine(valor[2]);
            }
        }
    }
}