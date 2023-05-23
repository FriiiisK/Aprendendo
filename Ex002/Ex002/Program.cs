using Ex002;
using System.Globalization;
using System;

namespace ex002
{
    class program
    {
        static void Main(string[] args)
        {
            {
                Funcionario f1 = new Funcionario();
                Funcionario f2 = new Funcionario();


                Console.WriteLine("Dados do primeiro funcionário: ");
                Console.Write("nome: ");
                f1.nome = Console.ReadLine();
                Console.Write("salário: ");
                f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("dados do segundo funcionário: ");
                Console.Write("nome: ");
                f2.nome = Console.ReadLine();
                Console.Write("salário: ");
                f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                double media = (f1.Salario + f2.Salario) / 2.0;
                Console.WriteLine("a média de salário é: " + media.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}