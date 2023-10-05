using System;

namespace Vetoresex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quartos[] vect = new Quartos[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int q = int.Parse(Console.ReadLine());

                vect[q] = new Quartos  (name,email );

            }
            Console.WriteLine();
            Console.WriteLine("Buse rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
