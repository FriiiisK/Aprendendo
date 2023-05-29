using Ex006_1_;
using System;
using System.Globalization;


namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a cotação do Dolar: ");
            CalculadoraDolar.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos Dolares irá comprar? ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Valor a ser pago em Reais: " + CalculadoraDolar.Valor(quant).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}