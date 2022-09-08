using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    //Sætter klassen Star til at nedarve fra klassen SpaceObjects
    internal class Star : SpaceObjects
    {
        //Opretter en public List, som indenbærer klassen Planet, med variablnavnet "planeList", og sætter den ligemed en ny Liste af Planet (dette skal gøres, ellers sætter den automatisk dereference til et null object reference -
        //da den tager Listen og kører fra NULL information, da ingen ny liste er oprettet - ergo er alt "information" NULL)
        public List<Planet> planetList = new List<Planet>();

        //Opretter en string property med variable navnet "Type"
        public string Type { get; set; }
        //Opretter en int property med variable navnet "Temperature"
        public int Temperature { get; set; }

        //Tilføjer property "position" af typen Position
        //new Position position { get; }

        //Opretter en Constructor for Star (som kun kan blive refereret til, hvis der ikke bliver sendt noget over i Constructoren)
        public Star()
        {
            //Instantierer en ny Position, og sender værdierne 0,0 videre
            //
            //Bedre forklaret:
            //Kalder min PositionClass og giver den variablenavnet position og sætter den ligmed en ny Position Class (fordi den sender 2 forskellige int, så ved -
            //jeg, at det er min Constructor den kalder og ikke min klasse, da Constructoren modtager 2 ints, og min Klasse kan "modtage" noget)
            //
            //Kunne også se sådan ud:
            //new Position position = new Position(0,0)
            this.Pos = new Position(0, 0);
        }
    }
}
