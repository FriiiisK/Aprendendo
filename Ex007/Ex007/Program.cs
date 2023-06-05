using System;
using System.Globalization;
namespace Ex007
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número da conta bancária: ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            String Nome = Console.ReadLine();
            Console.WriteLine("Haverá um deposito inicial? (s/n)");
            char DepositoInicial = char.Parse(Console.ReadLine());
            Double ValorInicial = 0;



            if (DepositoInicial == 's' || DepositoInicial == 'S')
            {
                Console.WriteLine("Insira o valor de deposito inicial: ");
                ValorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
            }
            
            ContaBanco conta = new ContaBanco(Id, Nome, ValorInicial);
            Console.WriteLine(conta);
            Console.Write("Insira um valor para deposito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(conta);
            Console.Write("Insira um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            
        }
    }
}