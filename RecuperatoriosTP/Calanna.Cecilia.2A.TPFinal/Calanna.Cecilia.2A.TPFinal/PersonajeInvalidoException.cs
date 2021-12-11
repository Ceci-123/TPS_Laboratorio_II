using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calanna.Cecilia._2A.TPFinal
{
    /// <summary>
    /// Excepcion si el personaje no es valido
    /// </summary>
    public class PersonajeInvalidoException :Exception
    {
        public PersonajeInvalidoException(string mensaje) : base(mensaje)
        {

        }
    }
}
