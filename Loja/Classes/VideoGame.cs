namespace Loja.Classes
{
    public class VideoGame : Produto
    {
        private string marca;
        private string modelo;
        private bool isUsado;

        public VideoGame()
        {
            
        }
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public string SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetModelo()
        {
            return this.modelo;
        }
        public string SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public bool GetIsUsado()
        {
            return this.isUsado;
        }
        public bool SetIsUsado(bool isUsado)
        {
            this.isUsado = isUsado;
        }
    }
}