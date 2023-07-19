using System;
using System.Globalization;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double N;
            int qtdnotas, resto, nota, moeda;



            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            resto = (int)((N * 100.0 + 0.5));

            Console.WriteLine("NOTAS:");


            nota = 100;
            qtdnotas = resto / (nota * 100);
            resto = resto  % (nota * 100);
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ".00");

            nota = 50;
            qtdnotas = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ".00");

            nota = 20;
            qtdnotas = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ".00");

            nota = 10;
            qtdnotas = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ".00");

            nota = 5;
            qtdnotas = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ".00");

            nota = 2;
            qtdnotas = resto / (nota * 100);
            resto = resto % (nota * 100);
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ".00");
            
            
            
            Console.WriteLine("MOEDAS:");


            moeda = 100;
            qtdnotas = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(qtdnotas + " moeda(s) de R$ 1.00");

            moeda = 50;
            qtdnotas = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(qtdnotas + " moeda(s) de R$ 0.50");

            moeda = 25;
            qtdnotas = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(qtdnotas + " moeda(s) de R$ 0.25");

            moeda = 10;
            qtdnotas = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(qtdnotas + " moeda(s) de R$ 0.10");

            moeda = 5;
            qtdnotas = resto / moeda;
            resto = resto % moeda;
            Console.WriteLine(qtdnotas + " moeda(s) de R$ 0.05");


            Console.WriteLine(resto + " moeda(s) de R$ 0.01");

        }
    }
}