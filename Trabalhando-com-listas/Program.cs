using Trabalhando_com_listas.Classes;

Pessoa p1 = new Pessoa();
List<Pessoa> lista = new List<Pessoa>();

lista.Add(new Pessoa("João", 15));
lista.Add(new Pessoa("Leandro", 21));
lista.Add(new Pessoa("Paulo", 17));
lista.Add(new Pessoa("Jessica", 18));

System.Console.WriteLine($"Total de pessoas na lista {lista.Count}");
p1.ListaPessoas(lista);

for (int i = 0; i < lista.Count; i++)
{
    if(lista[i].idade < 18)
    {
        lista.Remove(lista[i]);
    }
}
System.Console.WriteLine("");
System.Console.WriteLine($"Total de pessoas na lista {lista.Count}");
p1.ListaPessoas(lista);

var consulta1 =
    from cons in lista
    where cons.nome == "Jessica"
    // orderby cons.nome deixei só para lembrar
    select cons;

System.Console.WriteLine("Consulta LINQ por query: " + string.Join(",", consulta1));

var consulta2 = lista.Where(cons => cons.nome == "Jessica").ToList();

System.Console.WriteLine("Consulta LINQ por método: " + string.Join(",", consulta2));


