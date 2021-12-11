using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calanna.Cecilia._2A.TPFinal
{
    /// <summary>
    /// Excepcion si la fase no es valida
    /// </summary>
    public class FaseInvalidaException :Exception
    {
        public FaseInvalidaException(string mensaje) : base(mensaje)
        {

        }
    }
}
