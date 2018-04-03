using System;
using System.Collections.Generic;

namespace BoekLibary
{
    public class Bestellingen
    {
        private string _besteldetails;
        public static List<Bestellingdetails> Bestelling;

        public string Besteldetails { get => _besteldetails; set => _besteldetails = value; }

        public Bestellingen()
        {
            Bestelling = new List<Bestellingdetails>();
        }

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
    }
}