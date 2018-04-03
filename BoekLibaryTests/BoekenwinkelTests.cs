using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoekLibary.Tests
{
    [TestClass()]
    public class BoekenwinkelTests
    {
        [TestMethod()]
        public void NieuwBoekTest()
        {
            Afmeting testAfmeting = new Afmeting(5, 5, 5);
            var testBoek = new Boek("harry_potter_and_the_philospher_stone", "j.k.rowling", Enum_taal.Engels, 290, 12.49, testAfmeting, "1408855928", 20, 50, 34, "1");
            Boekenwinkel.NieuwBoek(testBoek);

            Equals(Product.Boekenlijst.Count == 1);
        }
    }
}   