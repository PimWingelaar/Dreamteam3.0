using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boek
{
    public class Boek : Product
    {
        private int isbn;
        private int minimum;
        private int maximaal;
        private int aantalvoorraad;
        private string druk;

        public Boek()
        {
            throw new System.NotImplementedException();
        }

        public int Aantalvoorraad
        {
            get => default(int);
            set
            {
            }
        }
    }
}