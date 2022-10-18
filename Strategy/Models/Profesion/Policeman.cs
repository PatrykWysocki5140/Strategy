using Strategy.Models.Profesion.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;

namespace Strategy.Models.Profesion
{
    internal class Policeman : ProfesionStrategy
    {

        public string Feature = "good man";

        public string MainFeature = "strong man";

        public string ExtraFeature = "fast man";

        private readonly ProfesionEnum type = ProfesionEnum.Policeman;

        public override Actor SetProffesion(Actor actor)
        {
            actor.Profesion = type;
            Console.WriteLine($"{actor.Name} is a {actor.Profesion} and {Feature} and {MainFeature}  and {ExtraFeature}");
            return actor;
        }
    }
}
