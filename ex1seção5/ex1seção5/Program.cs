using ex1seção5;
using System;
using System.ComponentModel;
using System.Xml;
using System.Globalization;

namespace ex1se5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write( "Entre o número da conta: " );
            int numero = int.Parse( Console.ReadLine() );
            Console.Write("entre o titular da conta: ");
            String titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse( Console.ReadLine() );

            if( resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture );
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);

            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);




        }
    }
}