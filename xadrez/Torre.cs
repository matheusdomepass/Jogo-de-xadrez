using System;
using Tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(TabuleiroOficial tabuleiro, Cor cor) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }

    }
}