using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galactica;

namespace Galactica
{
    //Laver ikke denne klasse sealed, da den ikke skal kunnes nedarves fra andre Klasser
    //Sætter klassen Moon til at nedarve fra klassen SpaceObjects
    sealed class Moon : Planet
    {
        //Tilføjer property "Orbiting" af typen Planet
        public Planet Orbiting { get; set; }

        //Metode forklaret under Planet
        public double Distance()
        {
            double distance = Math.Sqrt(Math.Pow(Orbiting.Pos.X - Pos.X, 2) + Math.Pow(Orbiting.Pos.Y - Pos.Y, 2));
            return distance;
        }
    }
}
