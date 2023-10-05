using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ex3notaaluno
{
    internal class Aluno
    {
        public double A;
        public double B;  
        public double C;
        public String N;
        


        public double NotaFinal()
        {
            return   A + B + C;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else { return false;}

            
        }
        public double NotaRestante()
        {
            if (Aprovado()) {
                return 0.0;
             } else { return 60.0 - NotaFinal();}

        }
                
                
        }

    }

