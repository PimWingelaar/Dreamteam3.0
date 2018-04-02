﻿using System;
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
            try
            {
                Product.Boekenlijst.Add(_objboek);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(@"No data found in the object Boek.");
            }
        }

        public static void VerwijderBoek(Boek _objboek)
        {
            if (Product.Boekenlijst.Contains(_objboek))
            {
                Product.Boekenlijst.Remove(_objboek);
            }
            else
            {
                Console.WriteLine(@"No data found that is similiar to objboek");
            }
        }

        public static void NieuwTijdschrift()
        {

        }

        public static void NieuwTijdschrift(Tijdschrijft _objtijdschrift)
        {
            try
            {
                Product.Tijdschriftenlijst.Add(_objtijdschrift);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(@"No data found in the object Tijdschrift.");
            }
        }

        public static void VerwijderTijdschrift(Tijdschrijft _objtijdschrijft)
        {
            if (Product.Tijdschriftenlijst.Contains(_objtijdschrijft))
            {
                Product.Tijdschriftenlijst.Remove(_objtijdschrijft);
            }
            else
            {
                Console.WriteLine(@"No data found that is similiar to objboek");
            }
        }

        public static string ToonAlleTijdschriften()
        {
            int lijst = 0;
            foreach (var _ in Product.Tijdschriftenlijst)
            {
                lijst++;
            }

            return lijst.ToString();
        }

        public static string ToonAlleBoeken()
        {
            int lijst = 0;
            foreach (var _ in Product.Boekenlijst)
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