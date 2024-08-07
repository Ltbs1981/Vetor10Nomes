Console.WriteLine("Bem vindo a lista de nomes!");

//indicando as opções do menu 
Console.WriteLine("Escolha: " +
    "\n 1-Inserir nome" +
    "\n 2-Inserir nome em ínice específico" +
    "\n 3-Exibir lista de nomes" +
    "\n 4-Exibir nomes em ordem alfabética" +
    "\n 5-Sair");

int opcao = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
        Console.WriteLine("Essa é o opção 1");
        break;
        case 2:
        Console.WriteLine("essa é o opção 2");
        break;
        case 3:
        Console.WriteLine("Essa é a opção 3");
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