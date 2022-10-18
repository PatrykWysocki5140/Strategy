using Strategy.Models;
using Strategy.Models.Profesion;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            City city = new City("Poznan",2);

            
            city.CreateBot("Adam","Nowak");
            city.CreateBot("Jan","Kowalski");
            city.CreateBot("Tomek","Kowalski2");
            city.CreateBot("Janusz","Nowak2");

            city.SetProfesion(new Citizen());
            List<Actor> actors = city.Actors(); 
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor.Name);
                Console.WriteLine(actor.Profesion);
            }

            city.SetProfesion(new Robber());
            actors = city.Actors();
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor.Name);
                Console.WriteLine(actor.Profesion);
            }

            city.SetProfesion(new Policeman());
            actors = city.Actors();
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor.Name);
                Console.WriteLine(actor.Profesion);
            }

            city.SetProfesion(new Villager());
            actors = city.Actors();
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor.Name);
                Console.WriteLine(actor.Profesion);
            }

            Console.ReadKey();

        }

    }
}