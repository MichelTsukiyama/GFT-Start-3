namespace Trabalhando_com_listas.Classes
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public Pessoa()
        {
            
        }
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void ListaPessoas(List<Pessoa>lista)
        {
            foreach (var item in lista)
            {
                System.Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.nome + "  Idade: " + this.idade;
            return retorno;
        }
    }

}