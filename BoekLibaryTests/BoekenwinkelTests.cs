using System;
using BoekLibary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoekLibaryTests
{
    [TestClass()]
    public class BoekenwinkelTests
    {
        [TestMethod()]
        public void NieuwBoekTest()
        {
            var testAfmeting = new Afmeting(5, 5, 5);
            var testBoek = new Boek("harry_potter_and_the_philospher_stone", "j.k.rowling", EnumTaal.Engels, 290, 12.49, testAfmeting, 1408855928, 20, 50, 34, "1", 1);
            Boekenwinkel.NieuwBoek(testBoek);

            Equals(Product.Boekenlijst.Count == 1);
        }

        [TestMethod()]
        public void NieuwTijdschriftTest()
        {
            var testAfmeting = new Afmeting(5, 5, 5);
            var testtijdschrift = new Tijdschrift("donald_duck", "walt disney", EnumTaal.Nederlands, 140, 4.99, testAfmeting, "16-02-2018", "20-02-2018", 54987618, 200, 1);
            Boekenwinkel.NieuwTijdschrift(testtijdschrift);

            Equals(Product.Tijdschriftenlijst.Count == 1);
        }

        [TestMethod()]
        public void BoekenwinkelTest()
        {
            var boekenwinkel = new Boekenwinkel(1, "Tel - 0612923821 | Email - test@boekenwinkel.nl  | Adres - Testlaan 1 Arnhem", "8:00 - 16:00");

            Assert.IsNotNull(boekenwinkel);
        }
    }
}   