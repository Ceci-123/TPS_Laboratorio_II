using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calanna.Cecilia._2A.TPFinal
{
    /// <summary>
    /// Interface - Clase 13
    /// </summary>
    public interface ISaga
    {
        /// <summary>
        /// Metodo desarrollado en la clase Pelicula
        /// </summary>
        /// <param name="unaPelicula"></param>
        /// <returns>Un entero </returns>
        public int DevolverFase(Pelicula unaPelicula);
    }
}
