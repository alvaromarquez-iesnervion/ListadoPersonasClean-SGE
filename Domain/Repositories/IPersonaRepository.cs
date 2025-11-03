using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using CleanPeopleList.Domain.Entities;

namespace CleanPeopleList.Domain.Repositories
{
    // Contrato que define cómo obtener datos de Persona
    public interface IPersonaRepository
    {
        IEnumerable<Persona> GetAll();
        
    }
}
