using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using CleanPeopleList.Domain.Entities;

namespace CleanPeopleList.Domain.Interfaces
{
    // Interfaz del caso de uso para listar personas
    public interface IGetListadoPersonasUseCase
    {
        IEnumerable<Persona> Execute();
    }
}
