using ScreenSound;
using System.Data;
using System.Diagnostics;
using ScreenSound.Modelos;

Banda ira = new("Ira");
ira.AdicionarNota(10);
ira.AdicionarNota(8);
ira.AdicionarNota(6);
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);


void ExibirLogo()
{
    string logo = @"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀";
    Console.WriteLine(logo);
    Console.WriteLine("Bem vino ao Screen Soud 2.0!");
}

void ExibirMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar álbum da banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite sua resposta: ");
    string? resposta =  Console.ReadLine();

    switch (resposta)
    {
        case "1":
            RegistrarUmaBanda();
            break;
        case "2":
            RegistrarAlbumDaBanda();
            break;
        case "3":
            MostrarTodasAsBandas();
            break;
        case "4":
            AvaliarBanda();
            break;
        case "5":
            DetalhesDeUmaBanda();
            break;
        case "-1":
            FinalizarConsole();
            break;
        default:
            OpcaoInvalida();
            break;
    }
}

void RegistrarUmaBanda()
{
    ExibirTitulo("Qual banda deseja registrar?");
    string resposta = Console.ReadLine()!;

    Banda banda = new(resposta);
    bandasRegistradas.Add(resposta, banda);

    Console.WriteLine($"\nBanda {resposta} registrada com sucesso.");

    Thread.Sleep(4000);
    ExibirMenu();
}

void RegistrarAlbumDaBanda()
{    
    ExibirTitulo("Registrar álbum de uma banda.");

    Console.Write("Qual banda você deseja registrar um álbum? ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Qual álbum deseja registrar? ");
        string nomeDoAlbum = Console.ReadLine()!;

        Banda banda = bandasRegistradas[nomeDaBanda];
        Album album = new(nomeDoAlbum);
        banda.AdicionarAlbum(album);

        Console.WriteLine($"\nO álbum {nomeDoAlbum} da banda {nomeDaBanda} foi registrado com sucesso.");
    }
    else
    {
        Console.WriteLine($"\nNão foi encontrada a banda {nomeDaBanda}.");
    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
    Console.ReadKey();
    ExibirMenu();
}

void MostrarTodasAsBandas()
{
    ExibirTitulo("Mostrar todas as bandas.");
    Console.WriteLine();
    foreach (var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"- {banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
    Console.ReadKey();
    ExibirMenu() ;    
}

void AvaliarBanda()
{
    ExibirTitulo("Avaliar banda");

    Console.Write("Digite o nome da nada que deseja avaliar?: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece?: ");
        int nota = int.Parse(Console.ReadLine()!);

        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarNota(nota);

        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
        Thread.Sleep(2000);
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
        Console.ReadKey();
        ExibirMenu();
    }
}

void DetalhesDeUmaBanda(){
    ExibirTitulo("Detalhe de uma banda");

    Console.Write($"\nQual banda deseja ver detalhes? ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é de {banda.Media}");
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
    }  

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
    Console.ReadKey();
    ExibirMenu();

}
void FinalizarConsole()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nEstamos finalizando em 3.");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nEstamos finalizando em 2.");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nEstamos finalizando em 1.");
    Thread.Sleep(1000);
}

void OpcaoInvalida(){
    Console.Clear();
    Console.WriteLine("A opção digitada está inválida.");
    Thread.Sleep(3000);
    ExibirMenu();    
}

void ExibirTitulo(string titulo)
{
    Console.Clear();
    int tamanhoTitulo = titulo.Length + 4;
    string asterisco = "*";
    Console.WriteLine(asterisco.PadLeft(tamanhoTitulo, '*'));
    Console.WriteLine($"* {titulo} *");
    Console.WriteLine(asterisco.PadLeft(tamanhoTitulo, '*'));
    Console.WriteLine();
}



ExibirMenu();

//234