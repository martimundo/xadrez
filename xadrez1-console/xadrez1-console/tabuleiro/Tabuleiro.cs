namespace tabuleiro
{
    internal class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;//Matriz de paças.

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];//controi a matriz
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];

        }
        //Metodo que verifica se existe uma peça em posição no tabuleito
        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }

        //Metodo que coloca a peça no tabuleiro
        //O metodo foi melhorada para verificar se ja existe uma peça no tabuleiro, pois caso ja tenha peça
        //o sistema precisa informar que ja tem peça no local.
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        //metodo para retirar peça do tabuleiro
        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }

            Peca aux = peca(pos);
            aux.posicao = null;

            pecas[pos.linha, pos.coluna] = null;

            return aux;
        }

        //valinha e colunas no tabuleiro
        public bool posicaoValida(Posicao posicao)
        {
            if (posicao.linha < 0 || posicao.linha >= linhas || posicao.coluna < 0 || posicao.coluna >= colunas)
            {

                return false;

            }
            return true;

        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida");
            }
        }
    }
}
