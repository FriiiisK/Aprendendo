using Ex005;
using System.Globalization;

namespace ex005
{
    class Program
    {
        static void Main(String[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Insira as 3 notas do Aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota Final: " + aluno.CalculoAprovacao(), CultureInfo.InvariantCulture);
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram: " + aluno.NotaFaltando().ToString("F2", CultureInfo.InvariantCulture));
            }




        }
    }
}