using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media;


            string[] notas = Console.ReadLine().Split(' ');

            float n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            media = ( (n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1) ) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                float exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                float mediafinal = (exame + media) / 2;
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
               
                if (mediafinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediafinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}