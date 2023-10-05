using System;
using System.Globalization;

namespace exerciciowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua sen: ");
            int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x != 2002)
            {
                
                Console.WriteLine("senha incorreta digite novamente : ");
                x = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("senha correta acesso permitido!");

        }
    }
}