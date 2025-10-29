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
        private readonly IPersonaRepository _personaRepository;


        public GetListadoPersonasUseCase(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public IEnumerable<Persona> Execute()
        {
            
            return _personaRepository.GetAll();
        }
    }
}
