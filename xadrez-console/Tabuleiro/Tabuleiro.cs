
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        //construtores
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];            
        }

        // Método que retorna uma peça( aqui ele consegue acessar a Peca na linha e coluna).
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {   //colocar uma peça no tabuleiro
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
