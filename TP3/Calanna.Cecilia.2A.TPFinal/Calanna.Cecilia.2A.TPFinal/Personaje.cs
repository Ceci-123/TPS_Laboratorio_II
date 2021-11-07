using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calanna.Cecilia._2A.TPFinal
{
    public class Personaje
    {
        protected string nombre;
        protected string alias;

        #region constructores

        /// <summary>
        /// Constructor sin parametros para serializar
        /// </summary>
        public Personaje()
        {

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="alias"></param>
        public Personaje(string nombre, string alias)
        {
            this.nombre = nombre;
            this.alias = alias;
        }


        #endregion
        #region sobrecargas
        /// <summary>
        /// Override de ToString 
        /// </summary>
        /// <returns>Una cadena con el nombre y el alias del personaje</returns>
        public override string ToString()
        {
            return this.nombre + " " + this.alias;
        }

        /// <summary>
        /// Sobrecarga del operador == retorna true si el nombre y el alias de un personaje coincide
        /// con el nombre y el alias de otro
        /// </summary>
        /// <param name="pje1"></param>
        /// <param name="pje2"></param>
        /// <returns>Un booleano</returns>
        public static bool operator ==(Personaje pje1, Personaje pje2)
        {
            return pje1.nombre == pje2.nombre && pje1.alias == pje2.alias;
        }

        /// <summary>
        /// Sobrecarga del operador 1= retorna false si el nombre y el alias de un personaje coincide
        /// con el nombre y el alias de otro
        /// </summary>
        /// <param name="pje1"></param>
        /// <param name="pje2"></param>
        /// <returns></returns>
        public static bool operator !=(Personaje pje1, Personaje pje2)
        {
            return !(pje1 == pje2);
        }

        /// <summary>
        /// Override para quitar el warning
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Override para quitar el warning
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Un booleano</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        #endregion
    }
}
