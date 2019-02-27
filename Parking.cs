using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Parking : Realty
    { 
        public Parking(int _registerNumber, string _location, int _area, double _rent) : base(_registerNumber, _location, _area, _rent)
        {
            //registerNumber = _registerNumber;
            //location = _location;
            //area = _area;
            //rent = _rent;
            // rien à rajouter car Parking n'a que les propriétés de base de Realty
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
