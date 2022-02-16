namespace Calcular_dias.Classes
{
    public class Calcular
    {
        private string nome { get; set; }
        private string data { get; set; }
        private TimeSpan intervalo { get; set; }

        public string SepararNome(string dados)
        {
            string[] arrayNomeData = dados.Split(' ', 2);
            return this.nome = arrayNomeData[0];
        }
        public string SepararData(string dados)
        {
            string[] arrayNomeData = dados.Split(' ', 2);
            return this.data = arrayNomeData[1].Replace(" ", "/");
        }
        public TimeSpan CalcularIntervalo(string dataEmString)
        {
            DateTime dataFormatada = DateTime.Parse(dataEmString);
            TimeSpan dias = DateTime.Now - dataFormatada;
            return this.intervalo = dias;
        }
        public void ExibirIntervalo()
        {
            System.Console.WriteLine($"{nome} viveu até hoje {intervalo.Days} dias");
        }



    }
}