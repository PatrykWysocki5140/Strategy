using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public abstract class ProfesionStrategy : IProfesion
    {
        public abstract Actor SetProffesion(Actor actor);
       
    }
}
