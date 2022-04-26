﻿

namespace tabuleiro
{
    abstract class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public  Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0;
        }

        public  void incrementaMovimento()
        {
            qteMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();

    }
}
