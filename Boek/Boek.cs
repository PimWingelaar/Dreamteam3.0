using System.Collections.Generic;
using System.Text;

namespace BoekLibary
{
    public class Boek : Product
    {

        #region Variables
        /// <summary>
        /// The isbn
        /// </summary>
        private long _isbn;
        /// <summary>
        /// The minimum
        /// </summary>
        private int _minimum;
        /// <summary>
        /// The maximaal
        /// </summary>
        private int _maximaal;
        /// <summary>
        /// The voorraad
        /// </summary>
        private int _voorraad;
        /// <summary>
        /// The druk
        /// </summary>
        private string _druk;
        private int _boekenwinkelid;

        /// <summary>
        /// Gets or sets the isbn.
        /// </summary>
        /// <value>
        /// The isbn.
        /// </value>
        public long ISBN { get => _isbn; set => _isbn = value; }
        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>
        /// The minimum.
        /// </value>
        public int Minimum { get => _minimum; set => _minimum = value; }
        /// <summary>
        /// Gets or sets the maximaal.
        /// </summary>
        /// <value>
        /// The maximaal.
        /// </value>
        public int Maximaal { get => _maximaal; set => _maximaal = value; }
        /// <summary>
        /// Gets or sets the voorraad.
        /// </summary>
        /// <value>
        /// The voorraad.
        /// </value>
        public int Voorraad { get => _voorraad; set => _voorraad = value; }
        /// <summary>
        /// Gets or sets the druk.
        /// </summary>
        /// <value>
        /// The druk.
        /// </value>
        public string Druk { get => _druk; set => _druk = value; }
        /// <summary>
        /// Gets or sets the boekenwinkelid.
        /// </summary>
        /// <value>
        /// The boekenwinkelid.
        /// </value>
        public int Boekenwinkelid{ get => _boekenwinkelid; set => _boekenwinkelid = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Boek"/> class.
        /// </summary>
        /// <param name="titel">The titel.</param>
        /// <param name="auteur">The auteur.</param>
        /// <param name="taal">The taal.</param>
        /// <param name="gewicht">The gewicht.</param>
        /// <param name="prijs">The prijs.</param>
        /// <param name="afmetingen">The afmetingen.</param>
        /// <param name="isbn">The isbn.</param>
        /// <param name="minimum">The minimum.</param>
        /// <param name="maximaal">The maximaal.</param>
        /// <param name="voorraad">The voorraad.</param>
        /// <param name="druk">The druk.</param>
        /// <param name="boekenwinkelid">The boekenwinkelid.</param>
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