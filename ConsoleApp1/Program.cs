using System;
using BoekLibary;

namespace BoekenWinkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testAfmeting = new Afmeting(5, 5, 5);

            var boekenwinkel = new Boekenwinkel(1, "Tel - 0612923821 | Email - test@boekenwinkel.nl  | Adres - Testlaan 1 Arnhem", "8:00 - 16:00");

            var testBoek = new Boek("harry_potter_and_the_philospher_stone", "j.k.rowling", Enum_taal.Engels, 290, 12.49, testAfmeting, 1408855928, 20, 50, 34, "1", 1);
            var testBoek2 = new Boek("harry_potter_and_the_goblet_of_fire", "j.k.rowling", Enum_taal.Engels, 300, 14.99, testAfmeting, 1456715498, 20, 50, 24, "1", 1);
            var testBoek3 = new Boek("harry_potter_and_the_prisoner_of_azkaban", "j.k.rowling", Enum_taal.Engels, 280, 15.00, testAfmeting, 2549738946, 20, 50, 44, "1", 1);
            var testBoek4 = new Boek("harry_potter_and_the_half_blood_prince", "j.k.rowling", Enum_taal.Engels, 280, 12.99, testAfmeting, 1642679426, 20, 50, 35, "1", 1);
            var testBoek5 = new Boek("harry_potter_and_the_order_of_the_phoenix", "j.k.rowling", Enum_taal.Engels, 300, 11.99, testAfmeting, 1646548496, 20, 50, 32, "1", 1);
            var testBoek6 = new Boek("harry_potter_and_the_deathly_hallows", "j.k.rowling", Enum_taal.Engels, 290, 12.99, testAfmeting, 1498764978, 20, 50, 23, "1", 1);

            var testtijdschrift = new Tijdschrift("donald_duck", "walt disney", Enum_taal.Nederlands, 140, 4.99, testAfmeting, "16-02-2018", "20-02-2018", 54987618, 200, 1);
            var testtijdschrift2 = new Tijdschrift("vtwonen", "ruben gijsbert", Enum_taal.Nederlands, 145, 5.50, testAfmeting, "17-02-2018", "18-02-2018", 98654879, 250, 1);
            var testtijdschrift3 = new Tijdschrift("autoweek", "frits huizen", Enum_taal.Nederlands, 135, 4.50, testAfmeting, "15-02-2018", "16-02-2018", 46987614, 240, 1);

            Console.WriteLine(boekenwinkel.ToString());

            Boekenwinkel.NieuwBoek(testBoek);
            Boekenwinkel.NieuwBoek(testBoek2);
            Boekenwinkel.NieuwBoek(testBoek3);
            Boekenwinkel.NieuwBoek(testBoek4);
            Boekenwinkel.NieuwBoek(testBoek5);
            Boekenwinkel.NieuwBoek(testBoek6);
            var test = Boekenwinkel.ToonAlleBoeken();

            Console.WriteLine(test);
            Console.WriteLine("=-=-=-=");
            Boekenwinkel.VerwijderBoek(testBoek3);
            Boekenwinkel.VerwijderBoek(testBoek6);

            Boekenwinkel.VerkoopBoek(1408855928, 5);
            test = Boekenwinkel.ToonAlleBoeken();
            Console.WriteLine(test);

            Console.WriteLine("=-=-=-=");
            Boekenwinkel.NieuwTijdschrift(testtijdschrift);
            Boekenwinkel.NieuwTijdschrift(testtijdschrift2);
            Boekenwinkel.NieuwTijdschrift(testtijdschrift3);
            test = Boekenwinkel.ToonAlleTijdschriften();

            Console.ReadLine();
        }
    }
}
