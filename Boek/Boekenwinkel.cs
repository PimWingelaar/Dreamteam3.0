using System;
using System.Collections.Generic;

namespace BoekLibary
{
    public class Boekenwinkel
    {

        #region Variables
        /// <summary>
        /// De boekenwinkelid
        /// </summary>
        private int _boekenwinkelid;
        /// <summary>
        /// De contactgegevens
        /// </summary>
        private string _contactgegevens;
        /// <summary>
        /// De openingstijden
        /// </summary>
        private string _openingstijden;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Boekenwinkel"/> class.
        /// </summary>
        /// <param name="boekenwinkelid">The boekenwinkelid.</param>
        /// <param name="contactgegevens">The contactgegevens.</param>
        /// <param name="openingstijden">The openingstijden.</param>
        public Boekenwinkel(int boekenwinkelid, string contactgegevens, string openingstijden)
		{
		    _boekenwinkelid = boekenwinkelid;
            _contactgegevens = contactgegevens;
            _openingstijden = openingstijden;
        }
		#endregion

		#region Methods
		public static string GenereerOrder()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verkoopt het boek.
        /// </summary>
        /// <param name="isbn">Het isbn.</param>
        /// <param name="aantal">het aantal.</param>
        public static void VerkoopBoek(long isbn, int aantal)
        {
            foreach (var boek in Product.Boekenlijst)
            {
                if (boek.ISBN == isbn)
                {
                    boek.Voorraad -= aantal;
                }
            }
        }

        /// <summary>
        /// Verkoopt het tijdschrift.
        /// </summary>
        /// <param name="issn">de issn.</param>
        /// <param name="aantal">het aantal.</param>
        public static void VerkoopTijdschrift(long issn, int aantal)
        {
            foreach (var tijdschrift in Product.Tijdschriftenlijst)
            {
                if (tijdschrift.ISSN == Convert.ToInt32(issn))
                {
                    tijdschrift.Bestelaantal -= aantal;
                }
            }
        }

        /// <summary>
        /// Nieuw boek toevoegen.
        /// </summary>
        /// <param name="_titel">The titel.</param>
        /// <param name="_auteur">The auteur.</param>
        /// <param name="_taal">The taal.</param>
        /// <param name="_gewicht">The gewicht.</param>
        /// <param name="_prijs">The prijs.</param>
        /// <param name="_lengte">The lengte.</param>
        /// <param name="_hoogte">The hoogte.</param>
        /// <param name="_breedte">The breedte.</param>
        /// <param name="_isbn">The isbn.</param>
        /// <param name="_minimum">The minimum.</param>
        /// <param name="_maximaal">The maximaal.</param>
        /// <param name="_aantalvoorraad">The aantalvoorraad.</param>
        /// <param name="_druk">The druk.</param>
        /// <param name="_boekenwinkelid">The boekenwinkelid.</param>
        public static void NieuwBoek(string _titel, string _auteur, Enum_taal _taal, int _gewicht, double _prijs, int _lengte,
            int _hoogte, int _breedte, long _isbn, int _minimum, int _maximaal, int _aantalvoorraad, string _druk, int _boekenwinkelid)
        {
            try
            {
                var _afmeting = new Afmeting(_breedte, _hoogte, _lengte);
                var _boek = new Boek(_titel, _auteur, _taal, _gewicht, _prijs, _afmeting, _isbn,
                    _minimum, _maximaal, _aantalvoorraad, _druk, _boekenwinkelid);
                Product.Boekenlijst.Add(_boek);
            }
            catch
            {
                Console.WriteLine("You have to enter data in the lines.");
            }
        }

        /// <summary>
        /// Nieuw boek toevoegen.
        /// </summary>
        /// <param name="_objboek">het objboek.</param>
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

        /// <summary>
        /// Verwijdert het boek.
        /// </summary>
        /// <param name="_objboek">The objboek.</param>
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

        /// <summary>
        /// Nieuw tijdschrift toevoegen.
        /// </summary>
        /// <param name="_titel">de titel.</param>
        /// <param name="_auteur">de auteur.</param>
        /// <param name="_taal">de taal.</param>
        /// <param name="_gewicht">het gewicht.</param>
        /// <param name="_prijs">de prijs.</param>
        /// <param name="_lengte">de lengte.</param>
        /// <param name="_breedte">de breedte.</param>
        /// <param name="_hoogte">de hoogte.</param>
        /// <param name="_uitgiftedag">de uitgiftedag.</param>
        /// <param name="_besteldag">de besteldag.</param>
        /// <param name="_issn">het issn.</param>
        /// <param name="_bestelaantal">het bestelaantal.</param>
        /// <param name="_boekenwinkelid">de boekenwinkelid.</param>
        public static void NieuwTijdschrift(string _titel, string _auteur, Enum_taal _taal, int _gewicht, double _prijs, int _lengte, int _breedte, int _hoogte, string _uitgiftedag, string _besteldag, long _issn, int _bestelaantal,int _boekenwinkelid)
        {
            try
            {
                var afmeting = new Afmeting(_breedte, _hoogte, _lengte);
                var tijdschrijft = new Tijdschrift(_titel, _auteur, _taal, _gewicht, _prijs, afmeting, _uitgiftedag,
                    _besteldag, _issn, _bestelaantal, _boekenwinkelid);
                Product.Tijdschriftenlijst.Add(tijdschrijft);
            }
            catch
            {
                Console.WriteLine("You have to enter data in the lines.");
            }
        }

        /// <summary>
        /// Nieuw tijdschrift toevoegen.
        /// </summary>
        /// <param name="objtijdschrift">het objtijdschrift.</param>
        public static void NieuwTijdschrift(Tijdschrift objtijdschrift)
        {
            try
            {
                Product.Tijdschriftenlijst.Add(objtijdschrift);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine(@"No data found in the object Tijdschrift.");
            }
        }

        /// <summary>
        /// Verwijdert het tijdschrift.
        /// </summary>
        /// <param name="objtijdschrijft">het objtijdschrijft.</param>
        public static void VerwijderTijdschrift(Tijdschrift objtijdschrijft)
        {
            if (Product.Tijdschriftenlijst.Contains(objtijdschrijft))
            {
                Product.Tijdschriftenlijst.Remove(objtijdschrijft);
            }
            else
            {
                Console.WriteLine(@"No data found that is similiar to objboek");
            }
        }

        /// <summary>
        /// Laat alle tijdschriften zien.
        /// </summary>
        /// <returns></returns>
        public static string ToonAlleTijdschriften()
        {
            var i = 0;
            foreach (var tijdschrift in Product.Tijdschriftenlijst)
            {
                var tijdschrijftstring = tijdschrift.Afdrukken();
                Console.WriteLine(tijdschrijftstring);
                i++;
            }

            return "There are " + i + " magazines in all stores";
        }

        /// <summary>
        /// Laat alle boeken zien.
        /// </summary>
        /// <returns></returns>
        public static string ToonAlleBoeken()
        {
            var i = 0;
            foreach (var boek in Product.Boekenlijst)
            {
                var boekstring = boek.Afdrukken();
                Console.WriteLine(boekstring);
                i++;
            }

            return "There are " + i + " books in all stores";
        }

        public static void LaatsteBestellingAfhandelen()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{_contactgegevens} | {_openingstijden}";
        }
		#endregion

	}
}