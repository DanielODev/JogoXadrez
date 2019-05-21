
namespace tabuleiro
{
    class Posicao
    {   // 
        public int linha { get; set; }
        public int coluna { get; set; }


        //construtor com argumentos
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //metodo ToString() usado para converter o objeto.
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
