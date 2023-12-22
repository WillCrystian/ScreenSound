using ScreenSound.Modelos;
using ScreenSound.Menus;

Banda ira = new("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);
void ExibirMenu()
{
    Console.Clear();
    Menu.ExibirLogo();
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
            MenuRegistrarUmaBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            ExibirMenu();
            break;
        case "2":
            MenuRegistrarAlbumDaBanda menu2 = new();
            menu2.Executar(bandasRegistradas);
            ExibirMenu();
            break;
        case "3":
            MenuMostrarTodasAsBandas menu3 = new();
            menu3.Executar(bandasRegistradas);
            ExibirMenu();
            break;
        case "4":
            MenuAvaliarBanda menu4 = new();
            menu4.Executar(bandasRegistradas);
            ExibirMenu();
            break;
        case "5":
            MenuDetalhesDeUmaBanda menu5 = new();
            menu5.Executar(bandasRegistradas);
            ExibirMenu();
            break;
        case "-1":
            MenuFinalizar menu6 = new();
            menu6.Executar(bandasRegistradas);
            break;
        default:
            OpcaoInvalida();
            break;
    }
}
void OpcaoInvalida(){
    Console.Clear();
    Console.WriteLine("A opção digitada está inválida.");
    Thread.Sleep(3000);
    ExibirMenu();    
}
ExibirMenu();