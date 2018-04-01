using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoekLibary
{
    public class Afmeting
    {
        private int _breedte;
        private int _hoogte;
        private int _lengte;

        public Afmeting()
        {
        }

        public Afmeting(int breedte, int hoogte, int lengte)
        {
            _breedte = breedte;
            _hoogte = hoogte;
            _lengte = lengte;
        }

        public int Breedte { get => _breedte; set => _breedte = value; }
        public int Hoogte { get => _hoogte; set => _hoogte = value; }
        public int Lengte { get => _lengte; set => _lengte = value; }
    }
}