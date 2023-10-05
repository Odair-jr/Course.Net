using System;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("bom dia");
            } 
            else if (hora <18) {
                Console.WriteLine("boa tarde");
            }
            else { 
                Console.WriteLine("boa noite");
            }
            

        }
    }
}