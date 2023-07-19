using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tempo = Console.ReadLine().Split(' ');

            int h1 = int.Parse(tempo[0]);
            int m1 = int.Parse(tempo[1]);
            int h2 = int.Parse(tempo[2]);
            int m2 = int.Parse(tempo[3]);

            int instanteInicial = h1 * 60 + m1;
            int instanteFinal = h2 * 60 + m2;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }

            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }


            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;


            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        }
    }
}