using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int X = int.Parse(Console.ReadLine());
          

           
            if ( X % 2 != 0 ) 
            {
                for (int i = 1; i <= X; i = i + 2)
                {

                    Console.WriteLine(i);

                }

            }
            
            else
            {
                for (int i = 1; i < X; i = i + 2)
                {

                    Console.WriteLine(i);

                }
            }
           

        }
    }
}

// OU 
//int x = int.Parse(Console.ReadLine());

//for (int i = 1; i <= x; i++)
//{
//if (i % 2 != 0)
//{
//Console.WriteLine(i);