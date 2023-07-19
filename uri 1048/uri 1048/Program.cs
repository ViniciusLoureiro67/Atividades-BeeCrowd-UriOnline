using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salario, reajuste, NovoSalario, reajusteganho, empercentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            NovoSalario = 0;
            reajuste = 0;
            empercentual = 0;
            reajusteganho = 0;

            if (salario >= 0 && salario <= 400.00)
            {
                reajuste = 15.0 / 100.0;
                NovoSalario = salario + (salario * reajuste);
                reajusteganho = NovoSalario - salario;
                empercentual = reajuste * 100;
               
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                reajuste = 12.0 / 100.0;
                NovoSalario = salario + (salario * reajuste);
                reajusteganho = NovoSalario - salario;
                empercentual = reajuste * 100;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = 10.0  / 100.0;
                NovoSalario = salario + (salario * reajuste);
                reajusteganho = NovoSalario - salario;
                empercentual = reajuste * 100;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = 7.0 / 100.0;
                NovoSalario = salario + (salario * reajuste);
                reajusteganho = NovoSalario - salario;
                empercentual = reajuste * 100;
            }
            else if (salario > 2000)
            {
                reajuste = 4.0 / 100.0;
                NovoSalario = salario + (salario * reajuste);
                reajusteganho = NovoSalario - salario;
                empercentual = reajuste * 100;
            }


            Console.WriteLine("Novo salario: " + NovoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajusteganho.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + empercentual.ToString("F0") + " %");

        }
    }
}