using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    internal class City
    {
        
        protected string? Name { get; set; }

        protected long CityId { get; set; }

        private List<Actor> actorsBufor = new List<Actor>();

        private List<Actor> actors = new List<Actor>();


        private ProfesionStrategy profesion;

        public City(string? name, int cityId)
        {
            SetName(name);
            SetId(cityId);
        }

        protected void SetName(string name)
        {
            this.Name = name;
        }
        protected void SetId(long id)
        {
            this.CityId = id;
        }

        public Actor CreateBot(string name,string surname)
        {
            Actor actor = new Actor();
            actor.Name = name;
            actor.Surname = surname;
            actorsBufor.Add(actor);
            return actor;
        }

        public Actor SetProfesion(Actor actor,ProfesionStrategy prof)
        {
            actors.Add(prof.SetProffesion(actor));
            return actor;
        }
        public void SetProfesion(ProfesionStrategy prof)
        {
            foreach(var obj in actorsBufor)
            {
                actors.Add(prof.SetProffesion(obj));
            }          
        }

        public List<Actor> Actors()
        {
            return actors;
        }

    }
}
