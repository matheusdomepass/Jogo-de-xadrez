using System;
using Tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            PosicaoXadrez pos1 = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.WriteLine(pos1.toPosicao());

            Console.ReadLine();
        }
    }
}