using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using CleanPeopleList.Domain.Entities;
using CleanPeopleList.Domain.Interfaces;
using CleanPeopleList.Domain.Repositories;

namespace CleanPeopleList.Domain.UseCases
{
    // Implementación del caso de uso IGetListadoPersonasUseCase
    public class GetListadoPersonasUseCase : IGetListadoPersonasUseCase
    {
        // Campo privado con guion bajo delante
        private readonly IPersonaRepository _personaRepository;

        // Constructor vacío requerido
        // OJO: esto deja _personaRepository en null si lo usas sin inyectar.
        // En runtime normal usaremos el otro constructor con inyección.
        public GetListadoPersonasUseCase()
        {
        }

        // Constructor principal con inyección de dependencias
        public GetListadoPersonasUseCase(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public IEnumerable<Persona> Execute()
        {
            // Protección básica por si alguien usa el constructor vacío
            // y no ha inyectado repositorio (evitamos null reference).
            // En clase puedes dejarlo o quitarlo, pero así no peta.
            if (_personaRepository == null)
            {
                return new List<Persona>();
            }

            return _personaRepository.GetAll();
        }
    }
}
