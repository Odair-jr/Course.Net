﻿using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else { Console.WriteLine("x is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y is null");
            }

            //operador de coalescência nula


            Console.WriteLine();
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}