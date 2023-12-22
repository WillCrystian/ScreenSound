using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuDetalhesDeUmaBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        ExibirTitulo("Detalhe de uma banda");

        Console.Write($"Qual banda deseja ver detalhes? ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é de {banda.Media}");
            Console.WriteLine("\nDiscografia");
            foreach(var album in banda.Albuns)
            {
                Console.WriteLine($"Ábum: {album.Nome} -> média: {album.Media}");
            }
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        }

        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
        Console.ReadKey();
    }
}
