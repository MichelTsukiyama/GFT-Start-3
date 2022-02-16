using Calcular_dias.Classes;

Calcular teste = new Calcular();
string data = "Vinicius 08 02 2021";

teste.SepararNome(data);
teste.SepararData(data);
teste.CalcularIntervalo(teste.SepararData(data));
teste.ExibirIntervalo();

// string[] nome1 = data.Split(' ', 2);


// System.Console.WriteLine(nome1[0]);
// System.Console.WriteLine(nome1[1].Replace(" ","/"));


// data1 = DateTime.Parse(nome1[1].Replace(" ", "/"));
// TimeSpan intervalo = DateTime.Now - data1;

// System.Console.WriteLine($"{intervalo.Days}");