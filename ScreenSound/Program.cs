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

Dictionary<int, Menu> menuOpcoes = new();
menuOpcoes.Add(1, new MenuRegistrarUmaBanda());
menuOpcoes.Add(2, new MenuRegistrarAlbumDaBanda());
menuOpcoes.Add(3, new MenuMostrarTodasAsBandas());
menuOpcoes.Add(4, new MenuAvaliarBanda());
menuOpcoes.Add(5, new MenuDetalhesDeUmaBanda());
menuOpcoes.Add(-1, new MenuFinalizar());


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
    int opcaoSelecionada = int.Parse(Console.ReadLine()!);

    if (menuOpcoes.ContainsKey(opcaoSelecionada))
    {
        if (opcaoSelecionada == -1)
        {
            Menu menu = menuOpcoes[opcaoSelecionada];
            menu.Executar(bandasRegistradas);            
        }
        else
        {
            Menu menu = menuOpcoes[opcaoSelecionada];
            menu.Executar(bandasRegistradas);
            ExibirMenu();
        }        
    }
    else
    {
        OpcaoInvalida();
    }
}
void OpcaoInvalida(){
    Console.Clear();
    Console.WriteLine("A opção digitada está inválida.");
    Thread.Sleep(3000);
    ExibirMenu();    
}
ExibirMenu();