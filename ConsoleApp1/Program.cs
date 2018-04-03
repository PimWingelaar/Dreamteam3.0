using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoekLibary;

namespace BoekenWinkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Afmeting testAfmeting = new Afmeting(5,5,5);
            var testBoek = new Boek("harry_potter_and_the_philospher_stone", "j.k.rowling", Enum_taal.Engels, 290 , 12.49 , testAfmeting, "1408855928" , 20, 50 , 34, "1");
            var testBoek2 = new Boek("harry_potter_and_the_goblet_of_fire", "j.k.rowling", Enum_taal.Engels, 300, 14.99, testAfmeting, "1456715498", 20, 50, 24, "1");
            var testBoek3 = new Boek("harry_potter_and_the_prisoner_of_azkaban", "j.k.rowling", Enum_taal.Engels, 280, 15.00, testAfmeting, "2549738946", 20, 50, 44, "1");
            var testBoek4 = new Boek("harry_potter_and_the_half_blood_prince", "j.k.rowling", Enum_taal.Engels, 280, 12.99, testAfmeting, "1642679426", 20, 50, 35 , "1");
            var testBoek5 = new Boek("harry_potter_and_the_order_of_the_phoenix", "j.k.rowling", Enum_taal.Engels, 300, 11.99, testAfmeting, "1646548496", 20, 50, 32, "1");
            var testBoek6 = new Boek("harry_potter_and_the_deathly_hallows", "j.k.rowling", Enum_taal.Engels, 290, 12.99, testAfmeting, "1498764978", 20, 50, 23, "1");
            var testtijdschrift = new Tijdschrift("donald_duck", "walt disney", Enum_taal.Nederlands, 140, 4.99, testAfmeting, "198", 1, 5, 3, "test");
            var testtijdschrift = new Tijdschrift("test", "test", Enum_taal.Nederlands, 5, 43, 29, testAfmeting, "1", 1, 5, 3, "test");

            Boekenwinkel.NieuwBoek(testBoek);
            Boekenwinkel.NieuwBoek(testBoek);

            Boekenwinkel.NieuwBoek(testBoek);
            Boekenwinkel.NieuwBoek(testBoek);
            Boekenwinkel.NieuwBoek(testBoek);
            Boekenwinkel.VerwijderBoek(testBoek);
            String test = Boekenwinkel.ToonAlleBoeken();
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
