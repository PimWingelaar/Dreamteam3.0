﻿using System;

namespace BoekLibary
{
	public class Bestellingdetails
    {

		#region Variables
		private int _besteldatum;
        private int _opsomming;
        private int _afgehandeld;

        public int Besteldatum { get => _besteldatum; set => _besteldatum = value; }
        public int Opsomming { get => _opsomming; set => _opsomming = value; }
        public int Afgehandeld { get => _afgehandeld; set => _afgehandeld = value; }
		#endregion

		#region Constructor
		public Bestellingdetails()
        {
            throw new NotImplementedException();
        }
		#endregion

		#region Methods
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
		#endregion
	
	}
}