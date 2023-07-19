using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string g1 = Console.ReadLine();
            

            if (g1 == "vertebrado")
            {
                string g2 = Console.ReadLine();
                if (g2 == "ave")
                {
                    string g3 = Console.ReadLine();
                    if (g3 == "carnivoro")
                        Console.WriteLine("aguia");
                    else if (g3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (g2 == "mamifero")
                {
                    string g3 = Console.ReadLine();
                    if (g3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (g3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (g1 == "invertebrado")
            {
                string g2 = Console.ReadLine();
                if (g2 == "inseto")
                {
                    string g3 = Console.ReadLine();
                    if (g3 == "hematofago")
                        Console.WriteLine("pulga");
                    else if (g3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (g2 == "anelideo")
                {
                    string g3 = Console.ReadLine();
                    if (g3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (g3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}
