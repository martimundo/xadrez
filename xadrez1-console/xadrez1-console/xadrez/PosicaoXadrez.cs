﻿using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;

        }
        //metodo para converter os caracteres no formato da matriz
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'A');
        }
        public override string ToString()
        {
            return " " + coluna + linha;
        }
    }
}
