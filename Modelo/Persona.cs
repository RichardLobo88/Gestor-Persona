using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16
{
   public abstract class Persona
    {
        private DateTime _fechaNacimiento;
        private int _numeroDeDocumento;
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string FechaNacimiento 
        {
            get 
            {
                return _fechaNacimiento.ToString("dd/MM/YYYY");
            }
            set
            {
                _fechaNacimiento = Convert.ToDateTime(value);
            }
        }

        public string NumeroDeDocumento {
            get
            {
                return _fechaNacimiento.ToString();
            }
            set 
            {
                int numeroDeDocumentoConvertido;
                var sePuedeConvertir = int.TryParse(value, out numeroDeDocumentoConvertido)


            if (!sePuedeConvertir)  
                {
                    _numeroDeDocumento = 0;
                }
                else 
                {
                    _numeroDeDocumento = numeroDeDocumentoConvertido;
                }
              
public int ObtenerEdad()
     {
            var fechaHoraActual = DateTime.Today;

            var EdadDateTime = fechaHoraActual - _fechaNacimiento;

            return (int)EdadDateTime.TotalDays / 365;
        }

    }
    }//Tryparse es un metodo de la clase INT, lo que hacemos es intentar convertir nuestro
     ////string a entero
}
