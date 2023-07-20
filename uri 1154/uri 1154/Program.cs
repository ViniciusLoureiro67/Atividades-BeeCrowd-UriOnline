using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtd, idade, idadetotal;

            idadetotal = 0;
            qtd = 0;

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                idadetotal += idade;
                qtd += 1;
                idade = int.Parse(Console.ReadLine());
            }

            double media = (double)idadetotal / qtd;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}