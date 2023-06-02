using System;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiroFuncionario = new Funcionario();
            Funcionario segundoFuncionario = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            primeiroFuncionario.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            primeiroFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            segundoFuncionario.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            segundoFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (primeiroFuncionario.Salario + segundoFuncionario.Salario) / 2.0;
            Console.Write("Salario medio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}