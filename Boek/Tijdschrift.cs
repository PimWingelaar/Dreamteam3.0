using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public class Tijdschrift : Product
    {
        #region Variables
        /// <summary>
        /// de uitgiftedag
        /// </summary>
        private string _uitgiftedag;
        /// <summary>
        /// de besteldag
        /// </summary>
        private string _besteldag;
        /// <summary>
        /// het issn
        /// </summary>
        private long _issn;
        /// <summary>
        /// het bestelaantal
        /// </summary>
        private int _bestelaantal;
        /// <summary>
        /// de boekenwinkelid
        /// </summary>
        private int _boekenwinkelid;

        /// <summary>
        /// Get of set de uitgiftedag.
        /// </summary>
        /// <value>
        /// de uitgiftedag.
        /// </value>
        public string Uitgiftedag { get => _uitgiftedag; set => _uitgiftedag = value; }
        /// <summary>
        /// Get of set de besteldag.
        /// </summary>
        /// <value>
        /// de besteldag.
        /// </value>
        public string Besteldag { get => _besteldag; set => _besteldag = value; }
        /// <summary>
        /// Get of set het issn.
        /// </summary>
        /// <value>
        /// het issn.
        /// </value>
        public long ISSN { get => _issn; set => _issn = value; }
        /// <summary>
        /// Get of set het bestelaantal.
        /// </summary>
        /// <value>
        /// het bestelaantal.
        /// </value>
        public int Bestelaantal { get => _bestelaantal; set => _bestelaantal = value; }
        /// <summary>
        /// Get of set de boekenwinkelid.
        /// </summary>
        /// <value>
        /// de boekenwinkelid.
        /// </value>
        public int Boekenwinkelid { get => _boekenwinkelid; set => _boekenwinkelid = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Tijdschrift"/> class.
        /// </summary>
        /// <param name="titel">de titel.</param>
        /// <param name="auteur">de auteur.</param>
        /// <param name="taal">de taal.</param>
        /// <param name="gewicht">het gewicht.</param>
        /// <param name="prijs">de prijs.</param>
        /// <param name="afmetingen">de afmetingen.</param>
        /// <param name="uitgiftedag">de  uitgiftedag.</param>
        /// <param name="besteldag">de besteldag.</param>
        /// <param name="issn">het issn.</param>
        /// <param name="bestelaantal">het bestelaantal.</param>
        /// <param name="boekenwinkelid">de boekenwinkelid.</param>
        public Tijdschrift(string titel, string auteur, EnumTaal taal, int gewicht, double prijs, Afmeting afmetingen, string uitgiftedag, string besteldag, long issn, int bestelaantal, int boekenwinkelid) : base(titel, auteur, taal, gewicht, prijs, afmetingen)
        {
            _uitgiftedag = uitgiftedag;
            _besteldag = besteldag;
            _issn = issn;
            _bestelaantal = bestelaantal;
            _boekenwinkelid = boekenwinkelid;
        }
        #endregion

        #region Method
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
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