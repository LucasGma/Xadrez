

namespace tabuleiro
{
    internal class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public override string ToString()
        {
            return linha + "," + coluna;
        }
    }
}
