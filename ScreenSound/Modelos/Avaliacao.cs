﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class Avaliacao
    {
        public Avaliacao(int nota)
        {
            Nota = nota;
        }

        public int Nota { get; }

        public static Avaliacao Parse(string s)
        {
            int numero = int.Parse(s);
            return new Avaliacao(numero); 
        }
    }
}
