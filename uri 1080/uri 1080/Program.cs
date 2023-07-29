using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valormaior = 0;
            int imomento = 0;

            for (int i = 1; i <= 100; i++)
            
            {
                
                int valor = int.Parse(Console.ReadLine());
                
                if (valor > valormaior
)
                {
                    valormaior = valor;
                    imomento = i;
                }

            }
            Console.WriteLine(valormaior);
            Console.WriteLine(imomento);

        }
    }
}