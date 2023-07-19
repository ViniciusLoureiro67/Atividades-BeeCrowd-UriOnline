using System;
using System.Globalization;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            double A, preco, total, qtd;


            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            qtd = double.Parse(vet[1]);


            if ( A == 1 )            {

                preco = 4.0;
                total = preco * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if ( A == 2)
            {
                preco = 4.5;
                total = preco * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (A == 3)
            {
                preco = 5.0;
                total = preco * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (A == 4)
            {
                preco = 2.0;
                total = preco * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (A == 5)
            {
                preco = 1.5;
                total = preco * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }


            





        }
    }
}