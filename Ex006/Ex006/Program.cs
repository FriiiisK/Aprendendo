using System;
using System.Globalization;

namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraMoeda calc = new CalculadoraMoeda();
            Console.Write("Insira a cotação do Dolar: ");
            calc.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos Dolares você vai Comprar? ");
            calc.Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em Reais: " + calc.Valor().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}