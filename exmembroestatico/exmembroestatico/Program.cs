using exmembroestatico;

using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {



            Console.Write("Qual é a contação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares voçê vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double convert = Convertor.ValorDoDolar(quantia, cotacao);

            Console.WriteLine("valor a ser pago em reais= " + convert.ToString("F2", CultureInfo.InvariantCulture));




        }




    }
}