using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

         

            string[] numero = (Console.ReadLine().Split(' '));

             int x = int.Parse(numero[0]);
             int y = int.Parse(numero[1]);
           

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
              
             numero = (Console.ReadLine().Split(' '));
                x = int.Parse(numero[0]);
                y = int.Parse(numero[1]);

            }

        }
    }
}