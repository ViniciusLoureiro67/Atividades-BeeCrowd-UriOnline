using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior, menor, soma;
            
            
           int X = int.Parse(Console.ReadLine());
           int Y = int.Parse(Console.ReadLine());   



            if (X < Y)
            {
                menor = X;
                maior = Y;
            }
            else
            {
                menor = Y;
                maior = X;
            }

            soma = 0;
            for (int i = menor + 1; i < maior ; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);

        }
    }
}