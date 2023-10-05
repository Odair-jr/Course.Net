using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex2poofuncionario
{
    internal class Funcionario
    {
        public String Nome;
        public Double Salario;
        public Double Imposto;
        


        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
                    + ", Salario liquido: R$"
                    + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
                    
                    
        }


    }
}
