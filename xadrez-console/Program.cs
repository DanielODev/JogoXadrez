using System;
using tabuleiro;

using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            //Console.WriteLine(pos);

            //Console.WriteLine(pos.toPosicao());

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Digite a posiçao de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    //mostra uma tela com as movimentaçoes possiveis destacadas de cada peça
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    // na classe tela foi criado outro metodo imprimir tabulero com as posicoesPossiveis como parametro.                 
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                    Console.WriteLine();
                    Console.Write("Digite a posição destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);



                }             
               
                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
