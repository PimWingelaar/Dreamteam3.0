using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public class Bestellingen
    {
        private List<Bestellingdetails> _bestelling;
        private string _besteldetails;

        public List<Bestellingdetails> Bestelling { get => _bestelling; set => _bestelling = value; }
        public string Besteldetails { get => _besteldetails; set => _besteldetails = value; }

        public Bestellingen()
        {
            throw new System.NotImplementedException();
        }

        public void Toevoegen(string _order)
        {
        }
        public void Verwijderen(int index)
        {
        }
        public void Verwijderen(string _order)
        {

        }

        public string PrintOrderOpDatum(DateTime _datum)
        {
            return null;
        }
    }
}