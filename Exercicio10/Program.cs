using System;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] auxiliar = Console.ReadLine().Split(' ');
            int m = int.Parse(auxiliar[0]);
            int n = int.Parse(auxiliar[1]);
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                auxiliar = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(auxiliar[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Posicao " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}