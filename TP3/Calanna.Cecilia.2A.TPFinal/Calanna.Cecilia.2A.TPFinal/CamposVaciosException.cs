using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calanna.Cecilia._2A.TPFinal
{
    public class CamposVaciosException :Exception
    {
        /// <summary>
        /// Excepcion si algun campo esta vacio en el formulario
        /// </summary>
        /// <param name="mensaje"></param>
        public CamposVaciosException(string mensaje) :this(mensaje, null)
        {
                
        }

        public CamposVaciosException(string mensaje, Exception innerException) :base(mensaje, innerException)
        {
                
        }

    }
}
