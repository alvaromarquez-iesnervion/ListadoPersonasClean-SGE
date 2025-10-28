using System.Collections.Generic;
using System.Linq;
using CleanPeopleList.Domain.Entities;
using CleanPeopleList.Domain.Repositories;

namespace CleanPeopleList.Data.Repositories
{
    // Implementación concreta de IPersonaRepository usando lista en memoria
    public class PersonaRepository : IPersonaRepository
    {
        // "Base de datos" simulada
        private static readonly List<Persona> _personas = new List<Persona>
        {
            new Persona(1, "María", "Gómez Pérez"),
            new Persona(2, "Juan", "López Sánchez"),
            new Persona(3, "Lucía", "Ramírez Ortega"),
            new Persona(4, "Carlos", "Ruiz Delgado"),
        };

        // Constructor vacío requerido
        public PersonaRepository()
        {
        }

        public IEnumerable<Persona> GetAll()
        {
            return _personas;
        }

        public Persona? GetById(int id)
        {
            return _personas.FirstOrDefault(p => p.Id == id);
        }
    }
}
