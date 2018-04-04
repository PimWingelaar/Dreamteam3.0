namespace BoekLibary
{
	
    public class Afmeting
    {
        #region Variables
        /// <summary>
        /// The breedte
        /// </summary>
        private int _breedte;
        /// <summary>
        /// The hoogte
        /// </summary>
        private int _hoogte;
        /// <summary>
        /// The lengte
        /// </summary>
        private int _lengte;

        /// <summary>
        /// Gets or sets the breedte.
        /// </summary>
        /// <value>
        /// The breedte.
        /// </value>
        public int Breedte { get => _breedte; set => _breedte = value; }
        /// <summary>
        /// Gets or sets the hoogte.
        /// </summary>
        /// <value>
        /// The hoogte.
        /// </value>
        public int Hoogte { get => _hoogte; set => _hoogte = value; }
        /// <summary>
        /// Gets or sets the lengte.
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
        /// <param name="breedte">The breedte.</param>
        /// <param name="hoogte">The hoogte.</param>
        /// <param name="lengte">The lengte.</param>
        public Afmeting(int breedte, int hoogte, int lengte)
        {
            _breedte = breedte;
            _hoogte = hoogte;
            _lengte = lengte;
		}
		#endregion
	}
}