string[] nomes = new string[3];
int opcao = 0; 
while (opcao != 6)
{

    Console.WriteLine("Bem vindo a lista de nomes!");

    //indicando as opções do menu 
    Console.WriteLine("Escolha: " +
        "\n 1-Inserir nome" +
        "\n 2-Inserir nome em ínice específico" +
        "\n 3-Exibir lista de nomes" +
        "\n 4-Ordenar nomes em ordem alfabética" +
        "\n 5-Apagar nome da lista"+
        "\n 6-Sair");

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
                        NomesOrdemAlfabetica(nomes);
            break;
        case 5:
                        ApagarNome(nomes);
            break;
       case 6:
            Console.WriteLine("Fim"); 
            break;
        default:
            Console.WriteLine("opção inválida, tente novamente!");
            break;
    }
}
//função inserir nome
static void InserirNome(string[] nomes)
{
    // verifica se a lista está cheia
    bool listaCheia = nomes.All(nome => !string.IsNullOrEmpty(nome));

    if (listaCheia)
    {
        Console.WriteLine("A lista está cheia! " +
            "\nEscolha um índice para apagar um nome da lista.");
        return;
    }

    // Solicita o nome a ser inserido
    Console.WriteLine("Informe o nome a ser inserido:");
    string nome = Console.ReadLine();

    // Insere o nome na primeira posição disponível
    for (int i = 0; i < nomes.Length; i++)
    {
        if (string.IsNullOrEmpty(nomes[i]))
        {
            nomes[i] = nome;
            Console.WriteLine("Nome inserido!");
            return;
        }
    }
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
    }

//função listar nomes
static void ListarNomes(string[] nomes)
{
    if (nomes.Length == 0 || nomes.All(string.IsNullOrEmpty))
    {
        Console.WriteLine("A lista de nomes está vazia.");
        return;
    }

    for (int i = 0; i < nomes.Length; i++)
    {
        if (!string.IsNullOrEmpty(nomes[i]))
        {
            Console.WriteLine(nomes[i]);
        }
    }
}

static void NomesOrdemAlfabetica(string[] nomes)
{
    for (int i = 0; i < nomes.Length - 1; i++)
    {
        for (int j = i + 1; j < nomes.Length; j++)
        {
            if (nomes[i] == null || nomes[j] == null)
                continue;

            // usando o compareTo
            if (nomes[i].CompareTo(nomes[j]) > 0)
            {
                //variavel temporaria para receber os nomes do vetor
                string temp = nomes[i];
                //vetor i, recebe vetor j
                nomes[i] = nomes[j];
                //vetor j recebe o conteúdo da estring temp
                nomes[j] = temp;
            }
        }
    }

    // Exibe os nomes em ordem alfabética
    Console.WriteLine("Nomes em ordem alfabética:");
    for (int i = 0; i < nomes.Length; i++)
    {
        if (nomes[i] != null)
        {
            Console.WriteLine(nomes[i]);
        }
    }
}

static void ApagarNome(string[] nomes)
{
    Console.WriteLine("Informe o índice que quer apagar o nome:");
    int indice = int.Parse(Console.ReadLine());

    for (int i = indice; i < nomes.Length - 1; i++)
    {
        nomes[i] = nomes[i + 1];
    }
        nomes[nomes.Length - 1] = null;
        }


            
