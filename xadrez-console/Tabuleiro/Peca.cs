

using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; set; }

        //construtor
        public Peca(Tabuleiro tab, Cor cor)
        {       // a posição deve ser null ao criar uma nova Peca
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

    }
}
