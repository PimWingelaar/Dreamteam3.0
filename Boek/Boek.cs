using System.Collections.Generic;
using System.Text;

namespace BoekLibary
{
    public class Boek : Product
    {
        private string _isbn;
        private int _minimum;
        private int _maximaal;
        private int _aantalvoorraad;
        private string _druk;

        public Boek(string titel, string auteur, Enum_taal taal, int gewicht, double prijs, Afmeting afmetingen, string isbn, int minimum, int maximaal, int aantalvoorraad, string druk) : base(titel, auteur, taal, gewicht, prijs, afmetingen)
        {
            _isbn = isbn;
            _minimum = minimum;
            _maximaal = maximaal;
            _aantalvoorraad = aantalvoorraad;
            _druk = druk;
        }

        public string Isbn { get => _isbn; set => _isbn = value; }
        public int Minimum { get => _minimum; set => _minimum = value; }
        public int Maximaal { get => _maximaal; set => _maximaal = value; }
        public int Aantalvoorraad { get => _aantalvoorraad; set => _aantalvoorraad = value; }
        public string Druk { get => _druk; set => _druk = value; }

        public string Afdrukken()
        {
            var stringbuilder = new StringBuilder()
                .Append("Titel: ")
                .Append(Titel)
                .Append(" Auteur: ")
                .Append(Auteur)
                .Append(" Taal: ")
                .Append(Taal)
                .Append(" Afmeting ")
                .Append(Afmetingen.Breedte)
                .Append("x" + Afmetingen.Lengte)
                .Append("x" + Afmetingen.Hoogte)
                .Append(" ISBN ")
                .Append(Isbn)
                .Append(" Minimum: ")
                .Append(Minimum)
                .Append(" Maximaal: ")
                .Append(Maximaal)
                .Append(" Aantalvoorraad: ")
                .Append(Aantalvoorraad)
                .Append(" Druk: ")
                .Append(Druk);


            return stringbuilder.ToString();
        }
    }
}