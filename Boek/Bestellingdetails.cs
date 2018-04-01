using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public class Bestellingdetails
    {
        private int _besteldatum;
        private int _opsomming;
        private int _afgehandeld;

        public Bestellingdetails()
        {
            throw new NotImplementedException();
        }

        public int Besteldatum { get => _besteldatum; set => _besteldatum = value; }
        public int Opsomming { get => _opsomming; set => _opsomming = value; }
        public int Afgehandeld { get => _afgehandeld; set => _afgehandeld = value; }


        public void Toevoegen(string _order) 
        {
        }
        public void Verwijderen(int index)
        {
        }
        public void Verwijderen(string _order)
        {

        }
    }
}