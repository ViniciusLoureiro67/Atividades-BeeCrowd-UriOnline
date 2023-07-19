using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N, nota, resto, qtdnotas;

            N = int.Parse(Console.ReadLine());

            Console.WriteLine(N);


            nota = 100;
            qtdnotas = N / nota;
            resto = N % nota;
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ",00");

            nota = 50;
            qtdnotas = resto / nota;
            resto = resto % nota;
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ",00");

            nota = 20;
            qtdnotas = resto / nota;
            resto = resto % nota;
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ",00");

            nota = 10;
            qtdnotas = resto / nota;
            resto = resto % nota;
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ",00");

            nota = 5;
            qtdnotas = resto / nota;
            resto = resto % nota;
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ",00");

            nota = 2;
            qtdnotas = resto / nota;
            resto = resto % nota;
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ",00");

            nota = 1;
            qtdnotas = resto / nota;
            resto = resto % nota;
            Console.WriteLine(qtdnotas + " nota(s) de R$ " + nota + ",00");





        }
    }
}