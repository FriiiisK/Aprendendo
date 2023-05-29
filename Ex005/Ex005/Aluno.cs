using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalculoAprovacao()
        {

            return Nota1 + Nota2 + Nota3;

        }
        public bool Aprovado()
        {
            if (CalculoAprovacao() > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaFaltando()
        {
            return (60 - CalculoAprovacao());
            
        }

    }
}
