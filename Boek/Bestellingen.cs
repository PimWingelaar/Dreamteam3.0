using System;
using System.Collections.Generic;

namespace BoekLibary
{
    public class Bestellingen
    {
		#region Variables
		private string _besteldetails;
        public static List<Bestellingdetails> Bestelling;

        public string Besteldetails { get => _besteldetails; set => _besteldetails = value; }
		#endregion

		#region Constructor
		public Bestellingen()
        {
            Bestelling = new List<Bestellingdetails>();
        }
		#endregion

		#region methods
		public void Toevoegen(string _order)
        {
            throw new NotImplementedException();
        }
        public void Verwijderen(int index)
        {
            throw new NotImplementedException();
        }
        public void Verwijderen(string _order)
        {
            throw new NotImplementedException();
        }

        public string PrintOrderOpDatum(DateTime _datum)
        {
            throw new NotImplementedException();
        }
		#endregion
	}
}