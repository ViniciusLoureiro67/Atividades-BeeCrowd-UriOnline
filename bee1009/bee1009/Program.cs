using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double vendas , salario, comissao, total;

            nome = (Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = vendas * 0.15;
            total = comissao + salario;


            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}