using ex3notaaluno;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno x, y;

            

            x = new Aluno();
            y = new Aluno();

            Console.WriteLine("Informe o nome do aluno e suas notas");
            Console.Write("Nome: ");
            x.N = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("digite as três notas do aluno: ");
            y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("nota final = " + y.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (y.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + y.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        }
    }
}
        }
    }
}
