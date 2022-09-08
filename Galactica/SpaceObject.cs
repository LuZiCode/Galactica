using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    //Laver klassen SpaceObjects til en partial class, så den kan nedarves fra
    public partial class SpaceObjects
    {
        //Opretter en int property med variable navnet "Id"
        public int Id { get; set; }
        //Opretter en string property med variable navnet "Name"
        public string Name { get; set; }
        //Opretter property "Orbiting" af typen Planet
        public Position Pos { get; set; }

        //Opretter en Enum, som er public (kan erklæres alle steder fra i dette objekt)
        //og giver følgende værdier: 0       1         2          3
        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }


        public class Position : SpaceObjects
        {
            //Opretter en Constructor for Position (som kun kan blive refereret til, hvis der ikke bliver sendt noget over i Constructoren)
            public Position()
            {

            }

            //Opretter en Constructor for Position (som kun kan blive refereret til, hvis der bliver sendt 2 forskellige int over i Constructoren)
            public Position(int position1, int position2)
            {
                Y = position2;
                X = position1;
            }

            //Opretter en double property med variable navnet "X"
            public double X { get; set; }

            //Opretter en double property med variable navnet "Y"
            public double Y { get; set; }

            ////Opretter en int property med variable navnet "Position1"
            //public int Position1 { get; }

            ////Opretter en int property med variable navnet "Position2"
            //public int Position2 { get; }

            ////Opretter en overrride metode (som tager ligegyldig hvilken string og overrider værdieen med min metode
            public override string ToString()
            {
                //Retunerer mine properties X & Y
                return $"({X}, {Y})";
            }
        }
    }
}
