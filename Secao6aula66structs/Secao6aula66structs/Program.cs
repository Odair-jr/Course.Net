using System;
using System.Drawing;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args, Point c)
        {
            
            c.X = 10;
            c.Y = 20;

            Console.WriteLine(c);
            c = new Point();
            Console.WriteLine(c);
        }
    }
}
