using System;
using Tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(TabuleiroOficial tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                for (int j = 0; j < tabuleiro.linhas; j++)
                {
                    if (tabuleiro.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.peca(i, j) + " ");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
