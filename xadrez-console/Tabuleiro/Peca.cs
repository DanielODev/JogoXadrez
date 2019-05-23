namespace tabuleiro
{
    abstract class Peca
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
                   
        public void incrementarQtdMovimenos()
        {
            qteMovimentos ++;
        }

        //metodo retorna se exixte movimentos possiveis/ verifica se a peça não está bloqueada para movimentos
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i<tab.linhas; i++)
            {
                for(int j=0; j < tab.colunas; j++)
                {
                    //if(mat[i,j])
                    if(mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //metodo pode mover para a dada posição?
        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
