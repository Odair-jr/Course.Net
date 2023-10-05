using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("nome e idade da primeira pessoa:");
            x.A = Console.ReadLine();
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("nome e idade da segunda pessoa:");
            y.A = Console.ReadLine();
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
           
            
            if (x.B > y.B)
            {
                Console.WriteLine("peessoa mais velha:" + x.A);
            }
            else
            {
                Console.WriteLine("peessoa mais velha:" + y.A);
            }
        }
    }
}