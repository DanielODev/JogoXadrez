using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);
                        Console.WriteLine();
                        Console.Write("Digite a posiçao de origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        //mostra uma tela com as movimentaçoes possiveis destacadas de cada peça
                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        // na classe tela foi criado outro metodo imprimir tabulero com as posicoesPossiveis como parametro.                 
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.WriteLine();
                        Console.Write("Digite a posição destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
