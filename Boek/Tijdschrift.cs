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
        /// The uitgiftedag
        /// </summary>
        private string _uitgiftedag;
        /// <summary>
        /// The besteldag
        /// </summary>
        private string _besteldag;
        /// <summary>
        /// The issn
        /// </summary>
        private long _issn;
        /// <summary>
        /// The bestelaantal
        /// </summary>
        private int _bestelaantal;
        /// <summary>
        /// The boekenwinkelid
        /// </summary>
        private int _boekenwinkelid;

        /// <summary>
        /// Gets or sets the uitgiftedag.
        /// </summary>
        /// <value>
        /// The uitgiftedag.
        /// </value>
        public string Uitgiftedag { get => _uitgiftedag; set => _uitgiftedag = value; }
        /// <summary>
        /// Gets or sets the besteldag.
        /// </summary>
        /// <value>
        /// The besteldag.
        /// </value>
        public string Besteldag { get => _besteldag; set => _besteldag = value; }
        /// <summary>
        /// Gets or sets the issn.
        /// </summary>
        /// <value>
        /// The issn.
        /// </value>
        public long ISSN { get => _issn; set => _issn = value; }
        /// <summary>
        /// Gets or sets the bestelaantal.
        /// </summary>
        /// <value>
        /// The bestelaantal.
        /// </value>
        public int Bestelaantal { get => _bestelaantal; set => _bestelaantal = value; }
        /// <summary>
        /// Gets or sets the boekenwinkelid.
        /// </summary>
        /// <value>
        /// The boekenwinkelid.
        /// </value>
        public int Boekenwinkelid { get => _boekenwinkelid; set => _boekenwinkelid = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Tijdschrift"/> class.
        /// </summary>
        /// <param name="titel">The titel.</param>
        /// <param name="auteur">The auteur.</param>
        /// <param name="taal">The taal.</param>
        /// <param name="gewicht">The gewicht.</param>
        /// <param name="prijs">The prijs.</param>
        /// <param name="afmetingen">The afmetingen.</param>
        /// <param name="uitgiftedag">The uitgiftedag.</param>
        /// <param name="besteldag">The besteldag.</param>
        /// <param name="issn">The issn.</param>
        /// <param name="bestelaantal">The bestelaantal.</param>
        /// <param name="boekenwinkelid">The boekenwinkelid.</param>
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