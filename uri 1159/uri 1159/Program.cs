using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            int x = int.Parse(Console.ReadLine());

            int par1, par2, par3, par4, par5, soma;
            soma = 0;

            while (x != 0)
            {
               
               if (x % 2 == 0)
                {
                    par1 = x;
                    par2 = x + 2;
                    par3 = par2 + 2;
                    par4 = par3 + 2;
                    par5 = par4 + 2;
                    soma = par1 + par2 + par3 + par4 + par5;

                    Console.WriteLine(soma);
                }
                else
                {
                    par1 = x + 1;
                    par2 = par1 + 2;
                    par3 = par2 + 2;
                    par4 = par3 + 2;
                    par5 = par4 + 2;

                    soma = par1 + par2 + par3 + par4 + par5;

                    Console.WriteLine(soma);
                }
              x = int.Parse(Console.ReadLine());

            }

        }
    }
}

// int x = int.Parse(Console.ReadLine());

// while (x != 0)
// {

// se for impar, some mais 1
// if (x % 2 != 0)
// {
// x = x + 1;
//    }

// expressao simplificada: 5 * x + 20
// int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
// Console.WriteLine(soma);

// x = int.Parse(Console.ReadLine());