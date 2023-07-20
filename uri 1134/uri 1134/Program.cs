using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1.Álcool 2.Gasolina 3.Diesel 4.Fim)
            int alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;


            int x = int.Parse(Console.ReadLine());
            


            while (x != 4) 
            { 
                  if ( x == 1 )
                  {
                     alcool += 1;
                  }
                  else if (x == 2)
                  {
                     gasolina += 1;
                  }
                  else if (x == 3)
                  {
                      diesel += 1;
                  }
             x = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}