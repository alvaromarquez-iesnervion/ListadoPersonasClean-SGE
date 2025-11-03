using CleanPeopleList.Domain.Entities;
using CleanPeopleList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PersonaRepositoryEmpty : IPersonaRepository
    {
        // "Base de datos" simulada
        private static readonly List<Persona> personasVacio = new List<Persona>
        {
            
        };

       


        public IEnumerable<Persona> GetAll()
        {
            return personasVacio  ;
        }

        
    }
}

