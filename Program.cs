﻿string[] nomes = new string[10];
int opcao = 0; 
while (opcao != 5)
{

    Console.WriteLine("Bem vindo a lista de nomes!");

    //indicando as opções do menu 
    Console.WriteLine("Escolha: " +
        "\n 1-Inserir nome" +
        "\n 2-Inserir nome em ínice específico" +
        "\n 3-Exibir lista de nomes" +
        "\n 4-Exibir nomes em ordem alfabética" +
        "\n 5-Sair");

    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            InserirNome(nomes);
            break;
        case 2:
            InserirNomeIndiceEscolhido(nomes);
                break;
        case 3:
            ListarNomes(nomes);
            break;
        case 4:
            Console.WriteLine("Essa é opção 4");
            break;
        case 5:
            Console.WriteLine("Obrigado!");
            break;
        default:
            Console.WriteLine("opção inválida, tente novamente!");
            break;
    }
}
//função inserir nome
static void InserirNome(string[] nomes)
{
    Console.WriteLine("Informe o nome a ser inserido");
    string nome = Console.ReadLine();
    for(int i = 0; i < nomes.Length; i++)
    {
        if( nomes[i] == null)
        {
            nomes[i] = nome;
            Console.WriteLine("Nome inserido!");
            return;
        }
        }
    Console.WriteLine("A lista está cheia! " +
        "\n Escolha um índice para apagar um nome da lista");
}

//função inserir nome em local escolhido
static void InserirNomeIndiceEscolhido(string[] nomes)
{
    Console.WriteLine("Informe o índice que quer adicionar o novo nome:");
    int indice = int.Parse(Console.ReadLine());

    if (indice < 0 || indice >= nomes.Length)
    {
        Console.WriteLine("Índice inválido!");
        return;
    }

    Console.WriteLine("Informe o nome a ser inserido:");
    string novoNome = Console.ReadLine();

    for (int i = nomes.Length - 1; i > indice; i--)
    {
        nomes[i] = nomes[i - 1];
    }

    // Inserir o novo nome na posição escolhida
    nomes[indice] = novoNome;

    //  array atualizado
    Console.WriteLine("Array atualizado:");
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine(nomes[i]);
    }
}
//função listar nomes
static void ListarNomes(string[] nomes)
{
    for (int i = 0; i < nomes.Length; i++) {
        Console.WriteLine(nomes[i]);
        
        }
}