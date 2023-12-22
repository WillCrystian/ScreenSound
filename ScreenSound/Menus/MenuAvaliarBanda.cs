using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTitulo("Avaliar banda");

        Console.Write("Digite o nome da nada que deseja avaliar?: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece? ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);            
            banda.AdicionarNota(nota);

            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
        }
    }
}
