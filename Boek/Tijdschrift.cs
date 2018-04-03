using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public class Tijdschrift : Product
    {
		#region Variables
		private int _uitgiftedag;
        private int _besteldag;
        private int _issn;
        private int _bestelaantal;

        public int Uitgiftedag { get => _uitgiftedag; set => _uitgiftedag = value; }
        public int Besteldag { get => _besteldag; set => _besteldag = value; }
        public int ISSN { get => _issn; set => _issn = value; }
        public int Bestelaantal { get => _bestelaantal; set => _bestelaantal = value; }
		#endregion

		#region Constructor
		public Tijdschrift(string titel, string auteur, Enum_taal taal, int gewicht, double prijs, Afmeting afmetingen, int uitgiftedag, int besteldag, int issn, int bestelaantal) : base(titel, auteur, taal, gewicht, prijs, afmetingen)
        {
            _uitgiftedag = uitgiftedag;
            _besteldag = besteldag;
            _issn = issn;
            _bestelaantal = bestelaantal;
        }
		#endregion

		#region method
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
                .Append(" Afmeting ")
                .Append(Afmetingen.Breedte)
                .Append("x" + Afmetingen.Lengte)
                .Append("x" + Afmetingen.Hoogte)
                .Append(" ISSN: ")
                .Append(ISSN)
                .Append(" Uitgiftedag: ")
                .Append(Uitgiftedag)
                .Append(" Besteldag: ")
                .Append(Besteldag)
                .Append(" Bestelaantal: ")
                .Append(Bestelaantal);
            
            return stringbuilder.ToString();
        }
		#endregion
	}
}