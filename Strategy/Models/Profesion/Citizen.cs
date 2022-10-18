using Strategy.Interfaces;
using Strategy.Models.Profesion.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.Profesion
{
    internal class Citizen : ProfesionStrategy
    {

        public string Feature = "poor man";

        public string CitizenFeature = "rich man in city";


        private readonly ProfesionEnum type = ProfesionEnum.Citizen;

        public override Actor SetProffesion(Actor actor)
        {
            actor.Profesion = type;
            Console.WriteLine($"{actor.Name} is a {actor.Profesion} and {Feature} and {CitizenFeature}");
            return actor;
        }
    }
}
