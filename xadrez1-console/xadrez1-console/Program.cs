﻿using tabuleiro;
using xadrez;
using xadrez1_console;
try
{
    Tabuleiro tabuleiro = new Tabuleiro(8, 8);

    tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
    tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 10));
    tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));

    Tela.imprimirTabuleiro(tabuleiro);
}
catch (TabuleiroException e)
{

    Console.WriteLine(e.Message);
}


