using System;
using Tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(TabuleiroOficial tabuleiro, Cor cor) : base(cor, tabuleiro) 
        {
        }

        public override string ToString()
        {
            return "R";
        }

    }
}
