namespace Loja.Classes
{
    public class Loja1
    {
        private string nome;
        private string cnpj;
        private List<Livro> livros;
        private List<VideoGame> videoGames;

        public Loja1()
        {
            
        }
        public Loja1(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;
        }

        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetCnpj()
        {
            return this.cnpj;
        }
        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }
 
        public List<Livro> GetLivros()
        {
            return this.livros;
        }

        public void SetLivros(List<Livro> livros)
        {
            this.livros = livros;
        }
        public List<VideoGame> GetVideoGames()
        {
            return this.videoGames;
        }
        public void SetVideoGames(List<VideoGame> videoGames)
        {
            this.videoGames = videoGames;
        }

        public void listaLivros()
        {
            System.Console.WriteLine($"A Loja {this.nome} possui estes livros para venda: ");
            foreach (var item in this.livros)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------------------------------------------------------------");      
        }
        public void listaVideoGames()
        {
            System.Console.WriteLine($"A Loja {this.nome} possui estes video-games para venda: ");
            foreach (var item in this.videoGames)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("----------------------------------------------------------------");     
        }
        public double calculaPatrimonio()
        {   
            double totalVideoGames = 0;
            double totalLivros = 0;
            double patrimonioTotal = 0;

            foreach (var item in videoGames)
            {
                totalVideoGames += item.GetPreco() * item.GetQtd();
            }
            
            foreach (var item in livros)
            {
                totalVideoGames += item.GetPreco() * item.GetQtd();
            }

            patrimonioTotal = totalLivros + totalVideoGames;

            System.Console.WriteLine($"O patrimonio da loja: {this.nome} ?? de R$ {patrimonioTotal.ToString("0.0").Replace(",",".")}");
            return patrimonioTotal;
        }
    }
}