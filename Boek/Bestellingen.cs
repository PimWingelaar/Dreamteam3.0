using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boek
{
    public class Bestellingen
    {
        private List<Bestelling> bestelling;
        private int besteldetails;

        public Bestellingen()
        {
            throw new System.NotImplementedException();
        }

        public Bestelling Bestelling
        {
            get => default(Boek.Bestelling);
            set
            {
            }
        }

        public Bestellingdetails Bestellingdetails
        {
            get => default(Boek.Bestellingdetails);
            set
            {
            }
        }
    }
}