using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = int.Parse(Console.ReadLine());

            Console.Write("Pessoa mais velha: ");
            if (primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.Write(primeiraPessoa.Nome);
            }
            else
            {
                Console.Write(segundaPessoa.Nome);
            }
        }
    }
}