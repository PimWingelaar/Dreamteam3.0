using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public class Boekenwinkel
    {
        private string _contactgegevens;
        private string _openingstijden;
        private List<Product> _voorraad;

        public Boekenwinkel(string contactgegevens, string openingstijden, List<Product> voorraad)
        {
            _contactgegevens = contactgegevens;
            _openingstijden = openingstijden;
            _voorraad = voorraad;
        }

        public static string GenereerOrder()
        {
            return "";
        }

        public static string VerkoopBoek(string _ISBN, int _aantal)
        {
            return "";
        }
        public static string VerkoopTijdschrift(string _ISSN, int _aantal)
        {
            return "";
        }

        public static void NieuwBoek()
        {
            
        }

        public static void NieuwBoek(Boek _objboek)
        {
            
        }

        public static void NieuwTijdschift()
        {

        }

        public static void NieuwTijdschift(Tijdschrijft _objtijdschrift)
        {

        }

        public static string ToonAlleTijdschriften()
        {
            return "";
        }

        public static string ToonAlleBoeken()
        {
            int lijst = 0;
            foreach (var _ in Boek.Boekenlijst)
            {
                lijst++;
            }

            return lijst.ToString();
        }

        public static void LaatsteBestellingAfhandelen()
        {
            
        }
    }
}