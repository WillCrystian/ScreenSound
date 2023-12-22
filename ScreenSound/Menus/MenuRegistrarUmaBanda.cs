using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarUmaBanda: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTitulo("Registrar uma banda");

        Console.Write("Qual banda você deseja registrar? ");
        string resposta = Console.ReadLine()!;

        Banda banda = new(resposta);
        bandasRegistradas.Add(resposta, banda);

        Console.WriteLine($"\nBanda {resposta} registrada com sucesso.");

        Thread.Sleep(4000);
    }
}
