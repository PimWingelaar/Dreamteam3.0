using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boek
{
    public class Tijdschrijft : Product
    {
        private int uitgiftedag;
        private int besteldag;
        private int issn;
        private int bestelaantal;

        public Tijdschrijft()
        {
            throw new System.NotImplementedException();
        }

        public int Bestelaantal
        {
            get => default(int);
            set
            {
            }
        }
    }
}