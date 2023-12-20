using ScreenSound;
using System.Data;
using System.Diagnostics;

List<string> bandas = new List<string>();

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
    bandas.Add(resposta);
    

    Thread.Sleep(5000);
    ExibirMenu();
}

void RegistrarAlbumDaBanda()
{

}

void MostrarTodasAsBandas()
{

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

