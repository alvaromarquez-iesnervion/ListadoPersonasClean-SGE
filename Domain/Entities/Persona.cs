using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanPeopleList.Domain.Entities
{
    public class Persona
    {
        // Propiedades públicas
        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        // Constructor vacío requerido
        public Persona()
        {
        }

        // Constructor completo
        public Persona(int id, string nombre, string apellidos)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
        }
    }
}
