namespace BoekLibary
{
	
    public class Afmeting
    {
        #region Variables
        /// <summary>
        /// de breedte
        /// </summary>
        private int _breedte;
        /// <summary>
        /// de hoogte
        /// </summary>
        private int _hoogte;
        /// <summary>
        /// de lengte
        /// </summary>
        private int _lengte;

        /// <summary>
        /// get of set de breedte.
        /// </summary>
        /// <value>
        /// de  breedte.
        /// </value>
        public int Breedte { get => _breedte; set => _breedte = value; }
        /// <summary>
        /// Gets of set de hoogte.
        /// </summary>
        /// <value>
        /// de hoogte.
        /// </value>
        public int Hoogte { get => _hoogte; set => _hoogte = value; }
        /// <summary>
        /// Gets of set de lengte.
        /// </summary>
        /// <value>
        /// The lengte.
        /// </value>
        public int Lengte { get => _lengte; set => _lengte = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Afmeting"/> class.
        /// </summary>
        public Afmeting()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Afmeting"/> class.
        /// </summary>
        /// <param name="breedte">de breedte.</param>
        /// <param name="hoogte">de hoogte.</param>
        /// <param name="lengte">de lengte.</param>
        public Afmeting(int breedte, int hoogte, int lengte)
        {
            _breedte = breedte;
            _hoogte = hoogte;
            _lengte = lengte;
		}
		#endregion
	}
}