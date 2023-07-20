using System;
using System.Globalization;

namespace uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, intertotal, gremiototal, qtd, vitinter, vitgremio, empate;




            string vencedor;
            empate = 0;
            qtd = 0;
            codigo = 1;
            vitinter = 0;
            vitgremio = 0;
            vencedor = "algum";

            while (codigo == 1)

            {
                string[] gols = Console.ReadLine().Split(' ');
                int golinter = int.Parse(gols[0]);
                int golgremio = int.Parse(gols[1]);

                qtd += 1;
                
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                codigo = int.Parse(Console.ReadLine());

                if (golinter > golgremio)
                {
                    vitinter += 1;
                }
                else if (golgremio > golinter)
                {
                    vitgremio += 1;
                }
                else
                {
                    empate += 1;
                }
                if (vitinter > vitgremio)
                {
                    vencedor = "Inter";
                }
                else
                {
                    vencedor = "Gremio";
                }

            }

            Console.WriteLine(qtd + " grenais");
            Console.WriteLine("Inter:" + vitinter);
            Console.WriteLine("Gremio:" + vitgremio);
            Console.WriteLine("Empates:" + empate);
            Console.WriteLine(vencedor + " venceu mais");

        }
    }
}