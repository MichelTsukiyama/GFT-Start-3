namespace Loja.Classes
{
    public class Livro : Produto
    {
        private string autor;
        private string tema;
        private int qtdPag;

        public Livro()
        {
            
        }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

         public string GetAutor()
        {
            return this.autor;
        }
        public string SetAutor(string autor)
        {
            this.autor = autor;
        }
         public string GetTema()
        {
            return this.tema;
        }
        public string SetTema(string tema)
        {
            this.tema = tema;
        }

         public int GetQtdPag()
        {
            return this.qtdPag;
        }
        public int SetQtdPag(int qtdPag)
        {
            this.qtdPag = qtdPag;
        }
    }
}