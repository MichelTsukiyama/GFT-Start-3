int numero;
int[] arrayNumeros = new int[5];
int maiorNumero = 0;
int menorNumero = 0;
int contador = 0;
int soma = 0;
int media;

for (int i = 0; i < arrayNumeros.GetLength(0); i++)
{
    System.Console.WriteLine("Digite um número");
    numero = int.Parse(Console.ReadLine());
    arrayNumeros[i] = numero;

    if(i == 0)
    {
        maiorNumero = numero;
        menorNumero = numero;
    }
    if(numero > maiorNumero)
    {
        maiorNumero = numero;
    }

    if(numero < menorNumero)
    {
        menorNumero = numero;
    }

    if(i > 0)
    {
        if(numero == arrayNumeros[i-1])
        {
            contador++;
        }
    }


    soma += numero;
}

media = soma/5;

System.Console.WriteLine($"O maior número é: {maiorNumero}");
System.Console.WriteLine($"O menor numero é: {menorNumero}");
System.Console.WriteLine($"A media dos valores é: {media}");

if(contador == 4)
{
    System.Console.WriteLine("Todos os valores são iguais");
}





