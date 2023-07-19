using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string produto1 = (Console.ReadLine());
   
            string[] vet = produto1.Split(' ');

            int codigo = int.Parse(vet[0]); 
            int qtd = int.Parse(vet[1]); 
            double valorunit = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double valor1 = valorunit * qtd;




            string produto2 = (Console.ReadLine());

            string[] vet2 = produto2.Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int qtd2 = int.Parse(vet2[1]);
            double valorunit2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valor2 = valorunit2 * qtd2;


            double valortotal = valor1 + valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valortotal.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}