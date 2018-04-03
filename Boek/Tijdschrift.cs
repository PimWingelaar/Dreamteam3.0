using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public class Tijdschrift : Product
    {
        private int uitgiftedag;
        private int besteldag;
        private int issn;
        private int bestelaantal;

        public Tijdschrift(string titel, string auteur, Enum_taal taal, int gewicht, double prijs, Afmeting afmetingen, int uitgiftedag, int besteldag, int issn, int bestelaantal) : base(titel, auteur, taal, gewicht, prijs, afmetingen)
        {
            this.uitgiftedag = uitgiftedag;
            this.besteldag = besteldag;
            this.issn = issn;
            this.bestelaantal = bestelaantal;
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