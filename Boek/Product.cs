using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Boek
{
    public abstract class Product
    {
        private string titel;
        private string auteur;
        private string taal;
        private int gewicht;
        private double prijs;
        private Afmeting afmetingen;

        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string Taal { get; set; }
        public int Gewicht { get; set; }
        public double Prijs { get; set; }
        public Afmeting Afmetingen { get; set; }


    }
}