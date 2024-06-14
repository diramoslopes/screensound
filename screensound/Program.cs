// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    //if (opcaoEscolhidaNumerica == 1)
    //{
    //    Console.WriteLine("Voce digitou a opção " + opcaoEscolhidaNumerica);
    //}
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        case 2:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        case 3:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;

        case 4:
            Console.WriteLine("Voce escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau tchau :) ");
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }


}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();