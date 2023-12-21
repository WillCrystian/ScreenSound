using ScreenSound;
using System.Data;
using System.Diagnostics;

//List<string> bandasRegistradas = new List<string> { "U2", "Ramones"};
Dictionary<string, List<string>> bandasRegistradas = new Dictionary<string, List<string>>();
bandasRegistradas.Add("U2", new List<string>());
bandasRegistradas.Add("Ira", new List<string>());
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
    bandasRegistradas.Add(resposta, new List<string>());

    Console.WriteLine($"\nBanda {resposta} registrada com sucesso.");

    Thread.Sleep(4000);
    ExibirMenu();
}

void RegistrarAlbumDaBanda()
{    
    ExibirTitulo("Registrar álbum de uma banda.");

    Console.Write("Qual banda você deseja registrar um álbum? ");
    string banda = Console.ReadLine()!;

    var bd = bandasRegistradas.Keys.Where(b => b == banda).Count();

    if (bd > 0)
    {
        Console.Write("Qual álbum deseja registrar? ");
        string album = Console.ReadLine()!;

        bandasRegistradas[banda].Add(album);

        Console.WriteLine($"\nO álbum {album} da banda {banda} foi registrado com sucesso.");
    }
    else
    {
        Console.WriteLine($"\nNão foi encontrada a banda {banda}.");
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

}

void DetalhesDeUmaBanda(){

}
void FinalizarConsole()
{

}

void OpcaoInvalida(){

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

