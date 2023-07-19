using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            
           A = int.Parse(Console.ReadLine());
           B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);


      



        }
    }
}