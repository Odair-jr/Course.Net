using System;
using System.Globalization;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) { 
            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("f3", CultureInfo.InvariantCulture));
                Console.Write("digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Número negativo!");

        }
    }
}