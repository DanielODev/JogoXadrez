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

        // criando uma sobrecarga para o método Peca
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];

        }
        //metodo para testar se existe uma peça em dada posição. Antes validar a posição
        public bool existePeca(Posicao pos)
        {
            validarPosiçao(pos);
            return peca(pos) != null;
        }

        // método para colocar a peça no lugar definido
        public void colocarPeca(Peca p, Posicao pos)
        {   //testar se existe uma peça na posiçao desejada.
            if (existePeca(pos))
            {
                throw new TabuleiroException("já existe uma peca nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

           //Método para retirar uma peça do tabuleiro/ retorna peça
           public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }




        // metodo para testar se uma posição é válida
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }// não precisa do else pq o return corta o método
            return true;
        }
        // metodo validar( caso a pos não seja válida ele lança uma excessão personalizada.
        public void validarPosiçao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
    }
}
