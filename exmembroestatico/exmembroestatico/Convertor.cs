using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exmembroestatico
{
    internal class Convertor
    {
        public static double Iof = 6.0;

        public static double ValorDoDolar(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total - total * Iof / 100.0;
        }

        


    }
}
