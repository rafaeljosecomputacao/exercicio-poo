using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            Console.Write("Quantos funcionarios vao ser registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionario.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o id do funcionario que tera o salario aumentado: ");
            int buscaId = int.Parse(Console.ReadLine());

            Funcionario funcionario = listaFuncionario.Find(x => x.Id == buscaId);
            if (funcionario != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id nao existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionarios:");
            foreach (Funcionario objeto in listaFuncionario)
            {
                Console.WriteLine(objeto);
            }
        }
    }
}