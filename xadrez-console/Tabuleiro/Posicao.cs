
namespace tabuleiro
{
    class Posicao
    {   // propriedades 
        public int linha { get; set; }
        public int coluna { get; set; }

        //construtor com argumentos 
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        // definir os valores das posiçoes em uma linha de comando apenas(ver pecas... rei, torre...)
        public void definirValores(int linha, int coluna) {
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
