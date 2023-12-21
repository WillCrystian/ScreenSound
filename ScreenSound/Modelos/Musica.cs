using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(string nome, Banda artista)
    {
        Nome = nome;
        Artista = artista;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Banda: {Artista}");
        Console.WriteLine($"Nome: {Duracao /1000}");
        if ( Disponivel )
        {
            Console.WriteLine($"A música está disponível no plano.");
        }
        else
        {
            Console.WriteLine($"Adquira o plano plus ++");
        }
        
    }
}
