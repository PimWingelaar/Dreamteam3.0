using System.Collections.Generic;

namespace BoekLibary
{
    public abstract class Product
    {
        #region Variables
        /// <summary>
        /// The titel
        /// </summary>
        private string _titel;
        /// <summary>
        /// The auteur
        /// </summary>
        private string _auteur;
        /// <summary>
        /// The taal
        /// </summary>
        private EnumTaal _taal;
        /// <summary>
        /// The gewicht
        /// </summary>
        private int _gewicht;
        /// <summary>
        /// The prijs
        /// </summary>
        private double _prijs;
        /// <summary>
        /// The afmetingen
        /// </summary>
        private Afmeting _afmetingen;
        /// <summary>
        /// The boekenlijst
        /// </summary>
        public static List<Boek> Boekenlijst;
        /// <summary>
        /// The tijdschriftenlijst
        /// </summary>
        public static List<Tijdschrift> Tijdschriftenlijst;

        /// <summary>
        /// Gets or sets the titel.
        /// </summary>
        /// <value>
        /// The titel.
        /// </value>
        public string Titel { get => _titel; set => _titel = value; }
        /// <summary>
        /// Gets or sets the auteur.
        /// </summary>
        /// <value>
        /// The auteur.
        /// </value>
        public string Auteur { get => _auteur; set => _auteur = value; }
        /// <summary>
        /// Gets or sets the taal.
        /// </summary>
        /// <value>
        /// The taal.
        /// </value>
        public EnumTaal Taal { get => _taal; set => _taal = value; }
        /// <summary>
        /// Gets or sets the gewicht.
        /// </summary>
        /// <value>
        /// The gewicht.
        /// </value>
        public int Gewicht { get => _gewicht; set => _gewicht = value; }
        /// <summary>
        /// Gets or sets the prijs.
        /// </summary>
        /// <value>
        /// The prijs.
        /// </value>
        public double Prijs { get => _prijs; set => _prijs = value; }
        /// <summary>
        /// Gets or sets the afmetingen.
        /// </summary>
        /// <value>
        /// The afmetingen.
        /// </value>
        public Afmeting Afmetingen { get => _afmetingen; set => _afmetingen = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="titel">The titel.</param>
        /// <param name="auteur">The auteur.</param>
        /// <param name="taal">The taal.</param>
        /// <param name="gewicht">The gewicht.</param>
        /// <param name="prijs">The prijs.</param>
        /// <param name="afmetingen">The afmetingen.</param>
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