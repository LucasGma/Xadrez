
using tabuleiro;
using System;
namespace Console_xadrez
{
    class Tela
    {
        public static void imprimirYabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.colunas; i++)
            {
                for (int j = 0; j < tab.linhas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i,j) + " ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}