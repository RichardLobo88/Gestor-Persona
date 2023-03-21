using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Repositorio
{
    internal class RepositorioDePersona
    {

        public List<Persona> Personas { get; set; }

        public RepositorioDePersona()
        { 
        Personas = new List<Persona>();
        }

        public void Insertar(Persona persona)
        {
            Persona.Add(persona);
        }

        public void Eliminar(string numeroDocumento)
        { 
        //Definir como eliminar una persona de la lista de persona


        }
        public void Actualizar(Persona persona)
        {
            Persona personaEncontrada;
            foreach (var personaActual in Persona)
            {
                if (personaActual.NumeroDeDocumento == persona.NumeroDeDocumento)
                {
                  
                    personaActual.Nombre = persona.Nombre;
                    personaActual.Apellido = persona.Apellido;
                    personaActual.FechaNacimiento = persona.FechaNacimiento;


                }
            }
        
        }
    }
}
