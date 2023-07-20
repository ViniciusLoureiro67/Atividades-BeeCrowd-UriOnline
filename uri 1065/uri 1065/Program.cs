using System;
using System.Globalization;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double PAR, POSITIVOS, NEGATIVOS, impar;
            PAR = 0;
            impar = 0;
            POSITIVOS = 0;
            NEGATIVOS = 0;


            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            // ____PARES___
            if ((a % 2) == 0)
            {
                PAR += 1;

            }

            if ((b % 2) == 0)
            {
                PAR += 1;

            }

            if ((c % 2) == 0)
            {
                PAR += 1;

            }

            if ((d % 2) == 0)
            {
                PAR += 1;

            }

            if ((e % 2) == 0)
            {
                PAR += 1;
                
            }

           

            // ___ POSITIVOS ___

            if (a > 0)
            {
                POSITIVOS += 1;
                
            }

            if (b > 0)
            {
                POSITIVOS += 1;
                
            }

            if (c > 0)
            {
                POSITIVOS += 1;
                
            }

            if (d > 0)
            {
                POSITIVOS += 1;
                
            }

            if (e > 0)
            {
                POSITIVOS += 1;
                
            }

            // ___ NEGATIVOS ___


            if (a < 0)
            {
                NEGATIVOS += 1;
               
            }

            if (b < 0)
            {
                NEGATIVOS += 1;

            }

            if (c < 0)
            {
                NEGATIVOS += 1;

            }

            if (d < 0)
            {
                NEGATIVOS += 1;

            }

            if (e < 0)
            {
                NEGATIVOS += 1;

            }

            // ___IMPARES___
            if ((a % 2) != 0)
            {
                impar += 1;

            }

            if ((b % 2) != 0)
            {
                impar += 1;

            }

            if ((c % 2) != 0)
            {
                impar += 1;

            }

            if ((d % 2) != 0)
            {
                impar += 1;

            }

            if ((e % 2) != 0)
            {
                impar += 1;

            }



            Console.WriteLine(PAR + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(POSITIVOS + " valor(es) positivo(s)");
            Console.WriteLine(NEGATIVOS + " valor(es) negativo(s)");
        }
    }
}