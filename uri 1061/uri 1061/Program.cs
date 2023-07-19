using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s;
            int duracao, acaba, comeca,;

            

             string[] comeco = Console.ReadLine().Split(' ');
             string[] hora1 = Console.ReadLine().Split(':');
             string[] termino = Console.ReadLine().Split(' ');
             string[] hora2 = Console.ReadLine().Split(':');


            acaba = int.Parse(termino[1]);
            comeca = int.Parse(comeco[1]);



            duracao = acaba - comeca;

















        }
    }
}