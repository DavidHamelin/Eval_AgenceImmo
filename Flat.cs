using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Flat : Realty
    {
        // ajout des attribut rooms et floor en plus de ceux de la class mere Realty
        private int rooms;
        private int floor;
        // On reprend la base de la class mere
        public Flat(int _registerNumber, string _location, int _area, double _rent, int _rooms, int _floor) : base(_registerNumber, _location, _area,  _rent)
        {
            //registerNumber = _registerNumber;
            //location = _location;
            //area = _area;
            //rent = _rent;
            rooms = _rooms;
            floor = _floor;
        }
        
        public override string ToString()
        {
            // retourne methode tostring de realty concaténé avec l'affichage de "rooms" et de "floor" propre à Flat
            return base.ToString() + $"Nombre de pièces : {rooms} \nEtage : {floor}\n";
        }
    }

}
