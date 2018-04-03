using System.Collections.Generic;
using System.Text;

namespace BoekLibary
{
    public class Boek : Product
    {
        private string _isbn;
        private int _minimum;
        private int _maximaal;
        private int _voorraad;
        private string _druk;

        public string ISBN { get => _isbn; set => _isbn = value; }
        public int Minimum { get => _minimum; set => _minimum = value; }
        public int Maximaal { get => _maximaal; set => _maximaal = value; }
        public int Voorraad { get => _voorraad; set => _voorraad = value; }
        public string Druk { get => _druk; set => _druk = value; }

        public Boek(string titel, string auteur, Enum_taal taal, int gewicht, double prijs, Afmeting afmetingen, string isbn, int minimum, int maximaal, int voorraad, string druk) : base(titel, auteur, taal, gewicht, prijs, afmetingen)
        {
            _isbn = isbn;
            _minimum = minimum;
            _maximaal = maximaal;
            _voorraad = voorraad;
            _druk = druk;
        }

        public string Afdrukken()
        {
            var stringbuilder = new StringBuilder()
                .Append("Titel: ")
                .Append(Titel)
                .Append(" Auteur: ")
                .Append(Auteur)
                .Append(" Taal: ")
                .Append(Taal)
                .Append(" Gewicht: ")
                .Append(Gewicht)
                .Append(" Prijs: ")
                .Append(Prijs)
                .Append(" Afmeting: ")
                .Append(Afmetingen.Breedte)
                .Append("x" + Afmetingen.Lengte)
                .Append("x" + Afmetingen.Hoogte)
                .Append(" ISBN: ")
                .Append(ISBN)
                .Append(" Minimum: ")
                .Append(Minimum)
                .Append(" Maximaal: ")
                .Append(Maximaal)
                .Append(" Voorraad: ")
                .Append(Voorraad)
                .Append(" Druk: ")
                .Append(Druk);


            return stringbuilder.ToString();
        }
    }
}