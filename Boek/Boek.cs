using System.Collections.Generic;
using System.Text;

namespace BoekLibary
{
    public class Boek : Product
    {

		#region Variables
		private long _isbn;
        private int _minimum;
        private int _maximaal;
        private int _voorraad;
        private string _druk;
        private int _boekenwinkelid;
            
        public long ISBN { get => _isbn; set => _isbn = value; }
        public int Minimum { get => _minimum; set => _minimum = value; }
        public int Maximaal { get => _maximaal; set => _maximaal = value; }
        public int Voorraad { get => _voorraad; set => _voorraad = value; }
        public string Druk { get => _druk; set => _druk = value; }
        public int Boekenwinkelid{ get => _boekenwinkelid; set => _boekenwinkelid = value; }
		#endregion

		#region Constructor
		public Boek(string titel, string auteur, Enum_taal taal, int gewicht, double prijs, Afmeting afmetingen, long isbn, int minimum, int maximaal, int voorraad, string druk, int boekenwinkelid) : base(titel, auteur, taal, gewicht, prijs, afmetingen)
        {
            _isbn = isbn;
            _minimum = minimum;
            _maximaal = maximaal;
            _voorraad = voorraad;
            _druk = druk;
            _boekenwinkelid = boekenwinkelid;
        }
		#endregion

		#region Method
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
                .Append(Druk)
                .Append(" Boekenwinkel: ")
                .Append(Boekenwinkelid);


            return stringbuilder.ToString();
        }
		#endregion
	}
}