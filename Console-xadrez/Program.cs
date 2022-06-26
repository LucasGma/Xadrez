using System;
using xadrez;
using tabuleiro;

namespace Console_xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Rei(Cor.Preta,tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(2, 4));

            Tela.imprimirYabuleiro(tab);
        }
    }
}
