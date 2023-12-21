﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;

internal class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<int> notas = new List<int>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Medias => notas.Average();
    public List<Album> Albums => albuns;

    public void AdicionarAlbum(Album algum)
    {
        albuns.Add(algum);
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }

}
