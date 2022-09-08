using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    //Jeg sætter min Enum udenfor Klassen, så den kan hentes/ændres på alle steder i projektet
    //Opretter en public Enum med variablnavnet "PlanetType" og giver den følgende værdier:
    //                          0          1      2        3
    public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

    //Sætter klassen Planet til at nedarve fra klassen SpaceObjects
    internal class Planet : SpaceObjects
    {
        //Opretter en public List, som indenbærer klassen Moon, med variablnavnet "moonList", og sætter den ligemed en ny Liste af Moon (dette skal gøres, ellers sætter den automatisk dereference til et null object reference -
        //da den tager Listen og kører fra NULL information, da ingen ny liste er oprettet - ergo er alt "information" NULL)
        public List<Moon> moonList = new List<Moon>();


        //Opretter en string property med variable navnet "PlanetType"
        public string PlanetType { get; set; }

        //Opretter en double property med variable navnet "DiameterInMeter"
        public double DiameterInMeter { get; set; }

        //Opretter en double property med variable navnet "RotationPeriodInHour"
        public double RotationPeriodInHour { get; set; }

        //Opretter en double property med variable navnet "RevolutionPeriodInDay"
        public double RevolutionPeriodInDay { get; set; }
        public double Distance(Star star)
        {
            //Opretter en ny double med variablenavnet "distance", som er det samme som: 
            // Math.Sqrt (metode til at finde kvadratroden af hele regnestykket) Math.Pow (Som bruges til at beregne-
            // et tal som er opløftet i et andet tals potens) star.position.X - position.X  (som er opløftet i anden potens) + Math.Pow (forklaret tidligere)
            // star.position.Y - position.Y (som er opløftet i anden potens)
            //
            //Forklaret på matematisk sprog:
            //Kvadrathoved af (X - X)^2 + (Y - Y)^2 + 
            double distance = Math.Sqrt(Math.Pow(star.Pos.X - Pos.X, 2) + Math.Pow(star.Pos.Y - Pos.Y, 2));
            return distance;
        }
    }
}
