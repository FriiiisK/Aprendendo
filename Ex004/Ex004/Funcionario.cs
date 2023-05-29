using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex004
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public Double SalLiq()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentoSalario(double Porcentagem)//defino o entre parenteses para fazer o calculo interno, pra chamar preciso chamar no corpo do programa
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * Porcentagem) / 100;
        }

        public override string ToString()
        {
            return Nome + "  R$ : " + SalLiq().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

