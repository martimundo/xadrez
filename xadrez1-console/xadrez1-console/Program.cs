﻿using tabuleiro;
using xadrez;
using xadrez1_console;

Tabuleiro tabuleiro = new Tabuleiro(8, 8);

tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

Tela.imprimirTabuleiro(tabuleiro);

