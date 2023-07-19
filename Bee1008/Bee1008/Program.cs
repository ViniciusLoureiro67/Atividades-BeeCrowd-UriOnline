using System;
using System.Globalization;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero, horast;
            double valor, salario;
            
            numero = int.Parse(Console.ReadLine());
            horast = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horast * valor;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));






        }
    }
}