using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public class Tijdschrift : Product
    {
		#region Variables
		private string _uitgiftedag;
        private string _besteldag;
        private long _issn;
        private int _bestelaantal;
        private int _boekenwinkelid;

        public string Uitgiftedag { get => _uitgiftedag; set => _uitgiftedag = value; }
        public string Besteldag { get => _besteldag; set => _besteldag = value; }
        public long ISSN { get => _issn; set => _issn = value; }
        public int Bestelaantal { get => _bestelaantal; set => _bestelaantal = value; }
        public int Boekenwinkelid { get => _boekenwinkelid; set => _boekenwinkelid = value; }
        #endregion

        #region Constructor
        public Tijdschrift(string titel, string auteur, Enum_taal taal, int gewicht, double prijs, Afmeting afmetingen, string uitgiftedag, string besteldag, long issn, int bestelaantal, int boekenwinkelid) : base(titel, auteur, taal, gewicht, prijs, afmetingen)
        {
            _uitgiftedag = uitgiftedag;
            _besteldag = besteldag;
            _issn = issn;
            _bestelaantal = bestelaantal;
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