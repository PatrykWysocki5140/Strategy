using Strategy.Interfaces;
using Strategy.Models.Profesion.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.Profesion
{
    internal class Villager : ProfesionStrategy
    {

        public string Feature = "poor man";

        private readonly ProfesionEnum type = ProfesionEnum.Villager;

        public override Actor SetProffesion(Actor actor)
        {
            actor.Profesion = type;
            Console.WriteLine($"{actor.Name} is a {actor.Profesion} and {Feature}");
            return actor;
        }
    }
}
