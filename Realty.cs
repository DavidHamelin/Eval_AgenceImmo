using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public abstract class Realty
    {
        protected int registerNumber;
        protected string location;
        protected int area;
        protected double rent;
        // le get ci-dessous permet de récupérer registerNumber afin de le comparer avec la saisie utilisateur
        public int RegisterNumber { get => registerNumber; }
        //public int RegisterNumber => registerNumber;

        public Realty(int _registerNumber, string _location, int _area, double _rent)
        {
            registerNumber = _registerNumber;
            location = _location;
            area = _area;
            rent = _rent;
        }

        public override string ToString()
        {
            return $"\nNuméro d'enregistrement : {registerNumber} \nLocalisation du bien : {location} \nSuperficie : {area} \nLoyer : {rent} \n";
        }
    }
}
