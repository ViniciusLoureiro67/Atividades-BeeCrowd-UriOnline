using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0;
            int fora = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }
        
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out" );

        }
    }
}