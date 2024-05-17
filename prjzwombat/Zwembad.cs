using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjzwombat
{
    internal class Zwembad
    {
        private double _diepte;
        private double _lengte;
        private double _breedte;
        private double _randafstand;

        public Zwembad()
        {
            _diepte = 2;
            _lengte = 2;
            _breedte = 2;
            _randafstand = 0.3;
        }

        public double Diepte
        {
            get { return _diepte; }
            set { _diepte = value; }
        }

        public double Lengte
        {
            get { return _lengte; }
            set { _lengte = value; }
        }

        public double Breedte
        {
            get { return _breedte; }
            set { _breedte = value; }
        }

        public double Randafstand
        {
            get { return _randafstand; }
            set { _randafstand = value; }
        }

        public Zwembad(double diepte, double lengte, double breedte, double randafstand)
        {
            Diepte = diepte;
            Lengte = lengte;
            Breedte = breedte;
            Randafstand = randafstand;
        }

        public virtual string Details()
        {
            return $"Er is {(Diepte - Randafstand) * Breedte * Lengte * 1000} liters water nodig\nof {(Diepte - Randafstand) * Breedte * Lengte} kubieke meter om dit\nzwembad te vullen.";
        }
    }
}
