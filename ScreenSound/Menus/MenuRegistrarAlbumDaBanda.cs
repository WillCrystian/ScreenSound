using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbumDaBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
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
    }
}
