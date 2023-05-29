using System;
using System.Globalization;

namespace Ex004;

class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();
        Console.Write("Nome: ");
        func.Nome = Console.ReadLine();
        Console.Write("Salario Bruto: ");
        func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine(func);
        Console.Write("Insira a porcentagem do aumento: ");
        double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // chamando a função descrita no funcionario, declaro uma variavel primeiro e dps faço a variavel virar parametro
        func.AumentoSalario(percent);
        Console.WriteLine("Salario Atualizado: " + func);

    }
}