﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public abstract class Product
    {
        private string _titel;
        private string _auteur;
        private Enum_taal _taal;
        private int _gewicht;
        private double _prijs;
        private Afmeting _afmetingen;
        public static List<Boek> Boekenlijst;
        public static List<Tijdschrift> Tijdschriftenlijst;

        internal Product(string titel, string auteur, Enum_taal taal, int gewicht, double prijs, Afmeting afmetingen)
        {
            Titel = titel;
            Auteur = auteur;
            Taal = taal;
            Gewicht = gewicht;
            Prijs = prijs;
            Afmetingen = afmetingen;
            Boekenlijst = new List<Boek>();
            Tijdschriftenlijst = new List<Tijdschrift>();
        }

        public string Titel { get => _titel; set => _titel = value; }
        public string Auteur { get => _auteur; set => _auteur = value; }
        public Enum_taal Taal { get => _taal; set => _taal = value; }
        public int Gewicht { get => _gewicht; set => _gewicht = value; }
        public double Prijs { get => _prijs; set => _prijs = value; }
        public Afmeting Afmetingen { get => _afmetingen; set => _afmetingen = value; }
    }
}