using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Galactica.SpaceObjects;

namespace Galactica
{
    internal class CreateValues
    {
        Position position = new Position();
        //Opretter en Constructor, som kun kan blive referet til uden nogle værdier bliver sendt ind i den.
        public CreateValues()
        {
            //Tilgår min metode
            CreateUniverse();
        }
        //Opretter en private metode, da den ikke skal kunne tilgås andre steder fra end denne Klasse
        private void CreateUniverse()
        {
            //instantierer klassen Star, så jeg kan ændre på værdierne inde i min Constructor
            Star sun = new Star()
            {
                Id = 1,
                Name = "Sun",
                Type = StarType.YellowDwarf.ToString(),
                Temperature = 5500
            };

            //Planets
            //instantierer klassen Planet, så jeg kan ændre på værdierne inde i min Constructor
            Planet mercury = new Planet()
            {
                Id = 1,
                Name = "Mercury",
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 2, Y = 1 }),
                DiameterInMeter = 4880000,
                RotationPeriodInHour = 1407,
                RevolutionPeriodInDay = 176,
            };
            Planet venus = new Planet()
            {
                Id = 2,
                Name = "Venus",
                PlanetType = PlanetType.Gas_Giant.ToString(),
                Pos = (new SpaceObjects.Position() { X = 4, Y = 6 }),
                DiameterInMeter = 2580000,
                RotationPeriodInHour = 2407,
                RevolutionPeriodInDay = 135,
            };
            Planet earth = new Planet()
            {
                Id = 3,
                Name = "Earth",
                PlanetType = PlanetType.Dwarf.ToString(),
                Pos = (new SpaceObjects.Position() { X = 7, Y = 8 }),
                DiameterInMeter = 3580000,
                RotationPeriodInHour = 3407.9,
                RevolutionPeriodInDay = 335.2,
            };
            Planet mars = new Planet()
            {
                Id = 4,
                Name = "Mars",
                PlanetType = PlanetType.Giant.ToString(),
                Pos = (new SpaceObjects.Position() { X = 9, Y = 10 }),
                DiameterInMeter = 6580000,
                RotationPeriodInHour = 1407,
                RevolutionPeriodInDay = 135.9,
            };
            Planet jupiter = new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                PlanetType = PlanetType.Giant.ToString(),
                Pos = (new SpaceObjects.Position() { X = 11, Y = 12 }),
                DiameterInMeter = 2580000,
                RotationPeriodInHour = 2407,
                RevolutionPeriodInDay = 435.2,
            };
            Planet saturn = new Planet()
            {
                Id = 6,
                Name = "Saturn",
                PlanetType = PlanetType.Giant.ToString(),
                Pos = (new SpaceObjects.Position() { X = 13, Y = 14 }),
                DiameterInMeter = 2580000,
                RotationPeriodInHour = 2407.2,
                RevolutionPeriodInDay = 435,
            };
            Planet uranus = new Planet()
            {
                Id = 7,
                Name = "UrAnus",
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 15, Y = 16 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407,
                RevolutionPeriodInDay = 435,
            };
            Planet neptune = new Planet()
            {
                Id = 8,
                Name = "UrAnus",
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 17, Y = 18 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407,
                RevolutionPeriodInDay = 435.8,
            };

            //Moons
            Moon luna = new Moon()
            {
                Id = 1,
                Name = "Luna",
                Orbiting = mars,
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 30, Y = 31 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407.1,
                RevolutionPeriodInDay = 435.2,
            };
            Moon titan = new Moon()
            {
                Id = 2,
                Orbiting = mars,
                Name = "Titan",
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 32, Y = 33 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407.1,
                RevolutionPeriodInDay = 435.2,
            };
            Moon phobos = new Moon()
            {
                Id = 3,
                Name = "Phobes",
                Orbiting = mars,
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 34, Y = 35 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407.1,
                RevolutionPeriodInDay = 435.2,
            };
            Moon europe = new Moon()
            {
                Id = 4,
                Name = "Europe",
                Orbiting = mars,
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 36, Y = 37 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407.1,
                RevolutionPeriodInDay = 435.2,
            };
            Moon deimos = new Moon()
            {
                Id = 5,
                Name = "Deimos",
                Orbiting = mars,
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 38, Y = 39 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407.1,
                RevolutionPeriodInDay = 435.2,
            };
            Moon ganymedes = new Moon()
            {
                Id = 6,
                Orbiting = mars,
                Name = "Ganymedes",
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 40, Y = 41 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407.1,
                RevolutionPeriodInDay = 435.2,
            };
            Moon io = new Moon()
            {
                Id = 7,
                Orbiting = mars,
                Name = "Io",
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 42, Y = 43 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407.1,
                RevolutionPeriodInDay = 435.2,
            };
            Moon mimas = new Moon()
            {
                Id = 8,
                Orbiting = mars,
                Name = "Mimas",
                PlanetType = PlanetType.Terrestial.ToString(),
                Pos = (new SpaceObjects.Position() { X = 34, Y = 35 }),
                DiameterInMeter = 2380000,
                RotationPeriodInHour = 2407.1,
                RevolutionPeriodInDay = 435.2,
            };


            //Tilføjelse af de oprettede planater til sun (Star klassen)'s Liste
            sun.planetList.Add(mercury);
            sun.planetList.Add(venus);
            sun.planetList.Add(earth);
            sun.planetList.Add(mars);
            sun.planetList.Add(jupiter);
            sun.planetList.Add(saturn);
            sun.planetList.Add(uranus);
            sun.planetList.Add(neptune);

            //Tilføjelse af de oprettede måner til planeter (Planet klassen)'s Liste
            earth.moonList.Add(luna);
            saturn.moonList.Add(titan);
            saturn.moonList.Add(mimas);
            mars.moonList.Add(phobos);
            mars.moonList.Add(deimos);
            jupiter.moonList.Add(europe);
            jupiter.moonList.Add(ganymedes);
            jupiter.moonList.Add(io);

            foreach (var Planet in sun.planetList)
            {
                Console.WriteLine($"\nInformation about {Planet.Name}:\nId: {Planet.Id}\n" + $"Name: {Planet.Name}\n" + $"Type: {Planet.PlanetType}\n" + $"Diameter in meters: {Planet.DiameterInMeter} \nCordinates: {Planet.Pos.ToString()} \nDistance to sun {Planet.Distance(sun)}");
                foreach (var Moon in Planet.moonList)
                {
                    Console.WriteLine($"\n\tMoon associated with {Planet.Name}: \n\tId: {Moon.Id} \n\tName: {Moon.Name}\n\tType: {Moon.PlanetType} \n\tDistance from Moon to Planet: {Moon.Distance()}");
                }
            }
        }

    }
}
