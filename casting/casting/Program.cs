using System;

namespace casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            double a = 10;
            float b = (float)a;

            Console.WriteLine(b);

            double c;
            int d;

            c = 5.1;
            d = (int)c;

            Console.WriteLine(d);
        }
    }
}