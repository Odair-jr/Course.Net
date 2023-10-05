using courseconstrutor;
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
             Produto p = new Produto("Tv", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());




        }
    }
}