using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //A = Math.Pow(x, y);       = Variável A recebe o resultado de x elevado a y
            

            double volume, pi, raio, raiocubo, quatrotres;

            pi = 3.14159;
            quatrotres = 4 / 3;

            raio = double.Parse(Console.ReadLine());

            raiocubo = (Math.Pow(raio, 3));

            volume =  (4.0 /3.0) * pi * raiocubo;


            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}