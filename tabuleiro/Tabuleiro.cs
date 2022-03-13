﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
        }

        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }

        public void colocarPeca(Peca peca, Posicao posicao)
        {
            if (existePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição");

            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }

        public Peca retirarPeca(Posicao posicao)
        {
            if (peca(posicao) == null)
            {
                return null;
            }

            Peca aux = peca(posicao);
            aux.posicao = null;
            pecas[posicao.linha, posicao.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao posicao)
        {
            return !(posicao.linha < 0 || posicao.linha >= linhas || posicao.coluna < 0 || posicao.coluna >= colunas);
        }

        public void validarPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao))
                throw new TabuleiroException("Posição inválida");
        }
    }
}
