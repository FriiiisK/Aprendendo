using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006_1_
{
    public static class CalculadoraDolar
    {
        public static double Dolar;
        public static double Iof()
        {
            return Dolar * 6 / 100;
        }

        public static Double Valor(double Quantidade)
        {
            return (Iof() + Dolar) * Quantidade;
        }
    }
}
