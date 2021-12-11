using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calanna.Cecilia._2A.TPFinal
{
    public class Serie :Universo
    {
        protected int cantidadDeCapitulos;
        protected Plataformas Plataforma;


        #region constructores
        public Serie(string nombre, DateTime fechaEstreno,int cantidadCapitulos, Plataformas plataforma)
            :base(nombre, fechaEstreno)
        {
            this.cantidadDeCapitulos = cantidadCapitulos;
            this.Plataforma = plataforma;
        }

        #endregion
        #region sobrecarga de operadores

        /// <summary>
        /// Sobrecarga el operador == para saber si un personaje esta en una serie
        /// </summary>
        /// <param name="serie"></param>
        /// <param name="pje"></param>
        /// <returns>Un booleano </returns>
        public static bool operator ==(Serie serie, Personaje pje)
        {
            bool respuesta = false;
            if (serie is not null && pje is not null)
            {
                foreach (Personaje item in serie.listaDePersonajes)
                {
                    if (item == pje)
                    {
                        respuesta = true;
                        break;
                    }
                }
            }
            return respuesta;
        }
        /// <summary>
        /// Sobrecarga del operador != para saber si un personaje no esta en una serie
        /// </summary>
        /// <param name="serie"></param>
        /// <param name="pje"></param>
        /// <returns>Un booleano</returns>
        public static bool operator !=(Serie serie, Personaje pje)
        {
            return !(serie == pje);
        }

        /// <summary>
        /// Sobrecarga del operador + para agregar un personaje a una serie
        /// </summary>
        /// <param name="serie"></param>
        /// <param name="pje"></param>
        /// <returns></returns>
        public static Serie operator +(Serie serie, Personaje pje)
        {
            if (serie is not null && pje is not null)
            {
                if (!(serie == pje))
                {
                    serie.listaDePersonajes.Add(pje);

                }
            }
            return serie;
        }

        /// <summary>
        /// Override del metodo Get Hash Code para eliminar el warning
        /// </summary>
        /// <returns>Un entero</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Override del metodo Equals, porque se sobrecarga el ==
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Un booleano</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Serie && (Serie)obj == this)
            {
                retorno = true;
            }
            return retorno;
            
        }
        #endregion

        #region metodos
        /// <summary>
        /// Muestra los datos de la serie
        /// </summary>
        /// <returns>Un string con los datos de la serie</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Cantidad de capitulos: " + this.cantidadDeCapitulos);
            sb.AppendLine("Plataforma: " + this.Plataforma);
            return sb.ToString();
        }

        /// <summary>
        /// Override de To String
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
