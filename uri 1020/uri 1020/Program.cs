using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int v, anos, meses, dias, resto;

            v = int.Parse(Console.ReadLine());

            anos = v / 365;
            resto = v % 365;
            Console.WriteLine(anos + " ano(s)");

            meses = resto / 30;
            resto = resto % 30;
            Console.WriteLine(meses + " mes(es)");
            
            dias = resto;
            Console.WriteLine(dias + " dia(s)");



        }
    }
}