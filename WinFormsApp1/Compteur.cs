﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Compteur
    {
        static private int _numero = 1;
        public int Compte { get; set; } = 0;
        public string Nom { get; init; } = "Compteur " + _numero++;
    }
}
