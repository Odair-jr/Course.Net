using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1pooretangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        

        public double ValorDaArea()
        {
            return Largura * Altura;
        }

        public double ValorDoPerimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double ValorDaDiagonal() 
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
        public override string ToString()
        {
            return "o valor da área é: "
                    + ValorDaArea().ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + "o valor do Perimetro é: "
                    + ValorDoPerimetro().ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + "o valor da Diagonal é :"
                    + ValorDaDiagonal().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
