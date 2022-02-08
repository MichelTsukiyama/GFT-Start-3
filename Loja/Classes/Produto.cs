namespace Loja.Classes
{
    public abstract class Produto
    {
        private string nome;
        private double preco;
        private int qtd;

        public Produto()
        {
            
        }
        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }

        public string GetNome()
        {
            return this.nome;
        }
        public string SetNome(string nome)
        {
            this.nome = nome;
        }

        public double GetPreco()
        {
            return this.preco;
        }
        public double SetPreco(double preco)
        {
            this.preco = preco;
        }

        public int GetQtd()
        {
            return this.qtd;
        }
        public int SetQtd(int qtd)
        {
            this.qtd = qtd;
        }
    }




    
}