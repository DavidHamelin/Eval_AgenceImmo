using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Home : Realty
    {
        private int rooms;

        public Home(int _registerNumber, string _location, int _area, double _rent, int _rooms) : base(_registerNumber, _location, _area, _rent)
        {
            registerNumber = _registerNumber;
            location = _location;
            area = _area;
            rent = _rent;
            rooms = _rooms;
        }
        public override string ToString()
        {
            return base.ToString() + $"Nombre de pièces : {rooms}\n";
        }
    }
}
