# Teste técnico GFT start#3

Versão utilizada .NET 6.0.100

---------------

Teste Calcular dias 

    //Não foi iniciado;

- foram criados métodos para separar o nome da data de nascimento, usando o método Split();
- criado método para calcular a quantidade de dias, utilizando DateTime.Parse() para receber a data em formato de string. E TimeSpan para calcular a diferença da data atual (DateTime.Now) com a data de nascimento da entrada.
- Criado método para exibir a quantidade de dias que a pessoa viveu.

-------------------------

Teste Leia-5-numeros 

- Remoção de diversas variáveis e condições, reduzindo a quantidade de linhas do código;

------------------

Teste Loja - 
    
    //Boa parte das classes, Getters e Setters criados, feita a classe abstrata, feito a herança, feitos os atributos privados.

Após refatorar:

- Criadas as Classes Produto, Loja1, Livro, VideoGame. (Obs. Nome da pasta é Loja, impossibilitando de criar uma classe com nome "Loja");
- Criada interface IImposto. (Tinha esquecido de colocar o I na frente do nome da Interface);
- Criados os getters e setters em todas as classes. (Inicialmente tinha feito errado, atribuído tipo aos setters, quando na verdade são void - sem retorno);
- Na classe abstrata foi utilizado 'protected' ao invés de 'private', o proteted permite que as cclasses filhas utilizem seus atributos utilizando o base.atributo;
- Feito polimorfismo no método calculaImposto() para que use taxas diferentes de acordo com o item;

----------------------

Teste Trabalhando com listas

    //faltou a consulta usando LINQ 
    
- Feita a consulta com LINQ (Método e Query).






