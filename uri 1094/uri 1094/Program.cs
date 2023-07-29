using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //sapos, ratos e coelhos
            int sapos = 0;
            int ratos = 0;
            int coelhos = 0;
            

            int qtdtest = int.Parse(Console.ReadLine());


            for (int i = 0; i < qtdtest; i++)
            {
               
                string[] vet = Console.ReadLine().Split(' ');
                int qtd = int.Parse(vet[0]);
                char animal = char.Parse(vet[1]);

                if (animal == 'S')
                {
                    sapos = sapos +qtd;
                }
                else if (animal == 'R')
                {
                    ratos =+ ratos + qtd;
                }
                else
                {
                    coelhos = coelhos + qtd;
                }

            }
            int total = sapos + ratos + coelhos;
            double porcentagemCoelhos = (double)coelhos / total * 100.0;
            double porcentagemRatos = (double)ratos / total * 100.0;
            double porcentagemSapos = (double)sapos / total * 100.0;


            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2") + " %");
        }
    }
}