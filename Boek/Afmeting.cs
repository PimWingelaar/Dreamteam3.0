namespace BoekLibary
{
	
    public class Afmeting
    {
		#region Variables
        private int _breedte;
        private int _hoogte;
        private int _lengte;

        public int Breedte { get => _breedte; set => _breedte = value; }
        public int Hoogte { get => _hoogte; set => _hoogte = value; }
        public int Lengte { get => _lengte; set => _lengte = value; }
		#endregion


		#region Constructors
        public Afmeting()
        {
        }

        public Afmeting(int breedte, int hoogte, int lengte)
        {
            _breedte = breedte;
            _hoogte = hoogte;
            _lengte = lengte;
		}
		#endregion
	}
}