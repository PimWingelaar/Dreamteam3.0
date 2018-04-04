using System;
using System.IO;
using BoekLibary;

namespace BoekenWinkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quit = false;
            Console.WriteLine("F2 TestMethode | F3 AddBook | F4 Stop");
            while (!quit)
            {
                if (!Console.KeyAvailable) continue;
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.F2:
                        TestMethode();
                        break;
                    case ConsoleKey.F3:
                        BoekToevoegen();
                        break;
                    case ConsoleKey.F4:
                        quit = true;
                        break;
                }
            }
        }

        public static void TestMethode()
        {
            var testAfmeting = new Afmeting(5, 5, 5);

            var boekenwinkel = new Boekenwinkel(1, "Tel - 0612923821 | Email - test@boekenwinkel.nl  | Adres - Testlaan 1 Arnhem", "8:00 - 16:00");

            var testBoek = new Boek("harry_potter_and_the_philospher_stone", "j.k.rowling", EnumTaal.Engels, 290, 12.49, testAfmeting, 1408855928, 20, 50, 34, "1", 1);
            var testBoek2 = new Boek("harry_potter_and_the_goblet_of_fire", "j.k.rowling", EnumTaal.Engels, 300, 14.99, testAfmeting, 1456715498, 20, 50, 24, "1", 1);
            var testBoek3 = new Boek("harry_potter_and_the_prisoner_of_azkaban", "j.k.rowling", EnumTaal.Engels, 280, 15.00, testAfmeting, 2549738946, 20, 50, 44, "1", 1);
            var testBoek4 = new Boek("harry_potter_and_the_half_blood_prince", "j.k.rowling", EnumTaal.Engels, 280, 12.99, testAfmeting, 1642679426, 20, 50, 35, "1", 1);
            var testBoek5 = new Boek("harry_potter_and_the_order_of_the_phoenix", "j.k.rowling", EnumTaal.Engels, 300, 11.99, testAfmeting, 1646548496, 20, 50, 32, "1", 1);
            var testBoek6 = new Boek("harry_potter_and_the_deathly_hallows", "j.k.rowling", EnumTaal.Engels, 290, 12.99, testAfmeting, 1498764978, 20, 50, 23, "1", 1);

            var testtijdschrift = new Tijdschrift("donald_duck", "walt disney", EnumTaal.Nederlands, 140, 4.99, testAfmeting, "16-02-2018", "20-02-2018", 54987618, 200, 1);
            var testtijdschrift2 = new Tijdschrift("vtwonen", "ruben gijsbert", EnumTaal.Nederlands, 145, 5.50, testAfmeting, "17-02-2018", "18-02-2018", 98654879, 250, 1);
            var testtijdschrift3 = new Tijdschrift("autoweek", "frits huizen", EnumTaal.Nederlands, 135, 4.50, testAfmeting, "15-02-2018", "16-02-2018", 46987614, 240, 1);

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

        public static void BoekToevoegen()
        {
            EnumTaal taal = 0;
            string titel = null;
            int boekenwinkel = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("Wat is de titel");
                titel = Console.ReadLine();
                Console.WriteLine("Wat is de acteur");
                string acteur = Console.ReadLine();
                Console.WriteLine("Wat is de taal");
                Console.WriteLine("0 = Nederlands");
                Console.WriteLine("1 = Engels");
                Console.WriteLine("2 = Frans");
                Console.WriteLine("3 = Duits");
                Console.WriteLine("");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.NumPad0)
                    taal = EnumTaal.Nederlands;
                if (key.Key == ConsoleKey.NumPad1)
                    taal = EnumTaal.Engels;
                if (key.Key == ConsoleKey.NumPad2)
                    taal = EnumTaal.Frans;
                if (key.Key == ConsoleKey.NumPad3)
                    taal = EnumTaal.Duits;
                Console.WriteLine("");
                Console.WriteLine("Wat is de gewicht");
                int gewicht = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is de prijs");
                double prijs = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wat is de lengte");
                int lengte = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is de breedte");
                int breedte = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is de hoogte");
                int hoogte = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is de ISBN");
                long isbn = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Wat is de minimaal");
                int minimaal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is de maximaal");
                int maximaal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is de voorraad");
                int voorraad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wat is de druk");
                string druk = Console.ReadLine();
                Console.WriteLine("Wat is de boekenwinkel");
                boekenwinkel = Convert.ToInt32(Console.ReadLine());
                Boekenwinkel.NieuwBoek(titel, acteur, taal, gewicht, prijs, lengte, hoogte, breedte, isbn, minimaal,
                    maximaal, voorraad, druk, boekenwinkel);
            }
            catch
            {
                Console.WriteLine("Er is iets fout gegaan in het maken van het boek.");
            }
            Console.Clear();

            Console.WriteLine($"Het boek {titel} is toegevoegd aan de boekenwinkel {boekenwinkel}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("F2 TestMethode | F3 AddBook | F4 Stop");
        }
    }
}
