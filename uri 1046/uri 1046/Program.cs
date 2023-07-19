using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] hora = Console.ReadLine().Split(' ');

            int h1 = int.Parse(hora[0]);
            int h2 = int.Parse(hora[1]);   


            if (h1 > h2)
            {
                Console.WriteLine("O JOGO DUROU " + ((h2 + 24) - (h1)) + " HORA(S)");

            }
            else if ( h1 == h2)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }

            else if ( h2 > h1)
            {
                Console.WriteLine("O JOGO DUROU " + (h2 - h1) + " HORA(S)");

            }

        }
    }
}