using System;
using System.Globalization;

namespace Ex003
{
    class program
    {
        static void Main(System.String[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a Largura e Altura do Triângulo: ");
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
