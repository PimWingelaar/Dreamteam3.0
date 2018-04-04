using System.Collections.Generic;

namespace BoekLibary
{
    public abstract class Product
    {
        #region Variables
        /// <summary>
        /// de titel
        /// </summary>
        private string _titel;
        /// <summary>
        /// de auteur
        /// </summary>
        private string _auteur;
        /// <summary>
        /// de taal
        /// </summary>
        private EnumTaal _taal;
        /// <summary>
        /// het gewicht
        /// </summary>
        private int _gewicht;
        /// <summary>
        /// de prijs
        /// </summary>
        private double _prijs;
        /// <summary>
        /// de afmetingen
        /// </summary>
        private Afmeting _afmetingen;
        /// <summary>
        /// de boekenlijst
        /// </summary>
        public static List<Boek> Boekenlijst;
        /// <summary>
        /// de tijdschriftenlijst
        /// </summary>
        public static List<Tijdschrift> Tijdschriftenlijst;

        /// <summary>
        /// Get of set de titel.
        /// </summary>
        /// <value>
        /// de titel.
        /// </value>
        public string Titel { get => _titel; set => _titel = value; }
        /// <summary>
        /// Get of set de auteur.
        /// </summary>
        /// <value>
        /// de auteur.
        /// </value>
        public string Auteur { get => _auteur; set => _auteur = value; }
        /// <summary>
        /// Get of set de taal.
        /// </summary>
        /// <value>
        /// de taal.
        /// </value>
        public EnumTaal Taal { get => _taal; set => _taal = value; }
        /// <summary>
        /// Get of set het gewicht.
        /// </summary>
        /// <value>
        /// het gewicht.
        /// </value>
        public int Gewicht { get => _gewicht; set => _gewicht = value; }
        /// <summary>
        /// Get of set de prijs.
        /// </summary>
        /// <value>
        /// de prijs.
        /// </value>
        public double Prijs { get => _prijs; set => _prijs = value; }
        /// <summary>
        /// Get of set de afmetingen.
        /// </summary>
        /// <value>
        /// de afmetingen.
        /// </value>
        public Afmeting Afmetingen { get => _afmetingen; set => _afmetingen = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="titel">de titel.</param>
        /// <param name="auteur">de auteur.</param>
        /// <param name="taal">de taal.</param>
        /// <param name="gewicht">het gewicht.</param>
        /// <param name="prijs">de prijs.</param>
        /// <param name="afmetingen">de afmetingen.</param>
        internal Product(string titel, string auteur, EnumTaal taal, int gewicht, double prijs, Afmeting afmetingen)
        {
            Titel = titel;
            Auteur = auteur;
            Taal = taal;
            Gewicht = gewicht;
            Prijs = prijs;
            Afmetingen = afmetingen;
            Boekenlijst = new List<Boek>();
            Tijdschriftenlijst = new List<Tijdschrift>();
        }
		#endregion
	}
}