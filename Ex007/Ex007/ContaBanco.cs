using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex007
{
     class ContaBanco
    {
        public string Nome;
        public int Id;
        public double ValorInicial;



        public ContaBanco(int id, String nome, Double valorinicial)
        {
            Nome = nome;
            Id = id;
            ValorInicial = valorinicial;
        }

        public void Deposito(double deposito)
        {
            ValorInicial = ValorInicial + deposito;
        }
        public void Saque(double saque)
        {
            ValorInicial = ValorInicial - saque - 5;
        }

        public override string ToString()
        {
            return "Conta: " + Id + ", Titular: " + Nome + ", Saldo: $ " + ValorInicial.ToString("F2", CultureInfo.InvariantCulture);
        }





    }
}





