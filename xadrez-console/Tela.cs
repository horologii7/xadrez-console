using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int l=0; l<tab.linhas; l++)
            {
                for (int c=0; c<tab.colunas; c++)
                {
                    Peca peca = tab.peca(l, c);
                    if (peca == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(peca + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
