using System;
using System.Globalization;

namespace Uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalvendas, p;


            Console.WriteLine();
            Console.Write("Digite o nome do vendedor : ");
            nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite o salário do vendedor : ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Digite o montante de vendas do mês : ");
            totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (double) (15.0/100.0);

            salario = (double)salario + (p * totalvendas);

            Console.WriteLine();
            Console.Write("Nome do vendedor : "+nome);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Salário total do vendedor : " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

        }
    }
}
