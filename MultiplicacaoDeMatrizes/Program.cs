using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicacaoDeMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // cada item da linha da matriz 1 multiplica cada item da coluna da matriz 2

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] resultado = new int[2, 2];

            Console.WriteLine("Preencher a primeira matriz #1");

            for (int linha = 0; linha < 2; linha++) // percorre a linha
            {
                for (int coluna = 0; coluna < 3; coluna++) // percorre cada "célula" da linha, colunas
                {
                    Console.Write("#1. Posição [" + linha + "][" + coluna + "]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencher a primeira matriz #2");

            for (int linha = 0; linha < 3; linha++) // percorre a linha
            {
                for (int coluna = 0; coluna < 2; coluna++) // percorre cada "célula" da linha
                {
                    Console.Write("#2. Posição [" + linha + "][" + coluna + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado da matriz #1 multiplicada pela matriz #2");

            resultado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resultado[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resultado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resultado[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + resultado[0, 0] + "][" + resultado[0, 1] + "]");
            Console.WriteLine("[" + resultado[1, 0] + "][" + resultado[1, 1] + "]");

            Console.ReadKey();
        }
    }
}
