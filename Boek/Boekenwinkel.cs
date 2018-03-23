using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boek
{
    public class Boekenwinkel
    {
        private string contactgegevens;
        private string openingstijden;
        private List<Product> voorraad;

        public Boekenwinkel()
        {
            throw new System.NotImplementedException();
        }

        public double Tijden
        {
            get => default(double);
            set
            {
            }
        }

        public string Contactggegevens
        {
            get => default(string);
            set
            {
            }
        }

        public int Voorraad
        {
            get => default(int);
            set
            {
            }
        }

        public Product Product
        {
            get => default(Boek.Eigenschappen);
            set
            {
            }
        }

        public void GetVoorraad()
        {
            throw new System.NotImplementedException();
        }

        public void GetContactgegevens()
        {
            throw new System.NotImplementedException();
        }

        public void GetTijd()
        {
            throw new System.NotImplementedException();
        }
    }
}