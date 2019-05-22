
namespace tabuleiro
{
    class Posicao
    {   // propriedades 
        public int linha { get; set; }
        public int coluna { get; set; }


        //construtor com argumentos / no caso o this é o escopo, se refere a propriedade da classe.
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
