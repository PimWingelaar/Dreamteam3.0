using System.Collections.Generic;
using System.Text;

namespace BoekLibary
{
    public class Boek : Product
    {

        #region Variables
        /// <summary>
        /// het isbn
        /// </summary>
        private long _isbn;
        /// <summary>
        /// het minimum
        /// </summary>
        private int _minimum;
        /// <summary>
        /// het maximaal
        /// </summary>
        private int _maximaal;
        /// <summary>
        /// de voorraad
        /// </summary>
        private int _voorraad;
        /// <summary>
        /// de druk
        /// </summary>
        private string _druk;
        private int _boekenwinkelid;

        /// <summary>
        /// Get of set het isbn.
        /// </summary>
        /// <value>
        /// het isbn.
        /// </value>
        public long ISBN { get => _isbn; set => _isbn = value; }
        /// <summary>
        /// Get of set het minimum.
        /// </summary>
        /// <value>
        /// het minimum.
        /// </value>
        public int Minimum { get => _minimum; set => _minimum = value; }
        /// <summary>
        /// Get of set het maximaal.
        /// </summary>
        /// <value>
        /// het maximaal.
        /// </value>
        public int Maximaal { get => _maximaal; set => _maximaal = value; }
        /// <summary>
        /// Get of set de voorraad.
        /// </summary>
        /// <value>
        /// de voorraad.
        /// </value>
        public int Voorraad { get => _voorraad; set => _voorraad = value; }
        /// <summary>
        /// Get of set de druk.
        /// </summary>
        /// <value>
        /// de druk.
        /// </value>
        public string Druk { get => _druk; set => _druk = value; }
        /// <summary>
        /// Get of set de boekenwinkelid.
        /// </summary>
        /// <value>
        /// de boekenwinkelid.
        /// </value>
        public int Boekenwinkelid{ get => _boekenwinkelid; set => _boekenwinkelid = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Boek"/> class.
        /// </summary>
        /// <param name="titel">de titel.</param>
        /// <param name="auteur">de auteur.</param>
        /// <param name="taal">de taal.</param>
        /// <param name="gewicht">het gewicht.</param>
        /// <param name="prijs">de prijs.</param>
        /// <param name="afmetingen">de afmetingen.</param>
        /// <param name="isbn">het isbn.</param>
        /// <param name="minimum">het minimum.</param>
        /// <param name="maximaal">het maximaal.</param>
        /// <param name="voorraad">de voorraad.</param>
        /// <param name="druk">de druk.</param>
        /// <param name="boekenwinkelid">de boekenwinkelid.</param>
        public Boek(string titel, string auteur, EnumTaal taal, int gewicht, double prijs, Afmeting afmetingen, long isbn, int minimum, int maximaal, int voorraad, string druk, int boekenwinkelid) : base(titel, auteur, taal, gewicht, prijs, afmetingen)
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