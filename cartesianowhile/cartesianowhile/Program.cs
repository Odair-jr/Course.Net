using System;
using System.Globalization;

Console.WriteLine("digite o valor de x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("digite o valor de y: ");
int y = int.Parse(Console.ReadLine());

while (x != 0 || y != 0)
{
    if (x >= 1 && y >= 1)
    {
        Console.WriteLine("quadrante 1");

        Console.WriteLine("digite o valor de x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("digite o valor de y: ");
        y = int.Parse(Console.ReadLine());
    }
    else if (x <= -1 && y >= 1)
    {
        Console.WriteLine("quadrante 2");

        Console.WriteLine("digite o valor de x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("digite o valor de y: ");
        y = int.Parse(Console.ReadLine());
    }
    else if (x <= -1 && y <= -1)
    {
        Console.WriteLine("quadrante 3");

        Console.WriteLine("digite o valor de x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("digite o valor de y: ");
        y = int.Parse(Console.ReadLine());

    }
    else if(x >= 1 && y <= -1)
    {
        Console.WriteLine("quadrante 4");

        Console.WriteLine("digite o valor de x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("digite o valor de y: ");
        y = int.Parse(Console.ReadLine());
    }
    else
    {
        
    }
}
