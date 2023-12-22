using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            ExibirTitulo("Avaliar álbum");

            Console.Write("O álbum pertence a qual banda? ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];

                Console.Write("Qual o nome do álbum? ");
                string nomeDoAlbum = Console.ReadLine()!;

                if (banda.Albuns.Any(a => a.Nome == nomeDoAlbum))
                {
                    Album album = banda.Albuns.First(a => a.Nome == nomeDoAlbum);

                    Console.Write($"Qual a nota do álbum {nomeDoAlbum}? ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

                    album.AdicionarNota(nota);

                    Console.WriteLine($"\nFoi registrado a nota {nota} para o ábum {nomeDoAlbum} da banda {nomeDaBanda}.");
                }
                else
                {
                    Console.WriteLine($"O álbum {nomeDoAlbum} não foi encontrado.");
                    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
                Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
                Console.ReadKey();
            }


        }
    }
}
