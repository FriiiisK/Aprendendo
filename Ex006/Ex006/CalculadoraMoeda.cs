using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    public class CalculadoraMoeda
    {
        public double Dolar;
        public double Quantidade;

        public double iof()
        {
            return Dolar * 6 / 100;
        }

        public double Valor ()
        {
            return Quantidade * (Dolar + iof());
        }
    }
}
