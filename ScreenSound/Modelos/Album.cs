using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public double Media
    {
        get 
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(n => n.Nota);
        }
    }
    public List<Musica> Musicas => musicas;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro, você precisa de {DuracaoTotal}.");
    }
}
