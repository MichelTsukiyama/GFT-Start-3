int numero;
int[] arrayNumeros = new int[5];
int soma = 0;

for (int i = 0; i < arrayNumeros.GetLength(0); i++)
{
    System.Console.WriteLine("Digite um número");
    numero = int.Parse(Console.ReadLine());
    arrayNumeros[i] = numero;
    soma += numero;
}

Array.Sort(arrayNumeros);

System.Console.WriteLine($"O maior número é: {arrayNumeros[4]}");
System.Console.WriteLine($"O menor numero é: {arrayNumeros[0]}");
System.Console.WriteLine($"A media dos valores é: {soma/5}");

if(arrayNumeros[0] == arrayNumeros[4])
{
    System.Console.WriteLine("Todos os valores são iguais");
}
