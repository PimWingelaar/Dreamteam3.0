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
            var testBoek = new Boek("test", "test", Enum_taal.Nederlands, 5 , 43.29 , testAfmeting, "1" , 1, 5 , 3, "Test");

            String test = Boekenwinkel.ToonAlleBoeken();
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
