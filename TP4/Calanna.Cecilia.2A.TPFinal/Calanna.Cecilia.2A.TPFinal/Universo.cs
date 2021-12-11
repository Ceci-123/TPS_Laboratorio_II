using System;
using System.Collections.Generic;
using System.Text;

namespace Calanna.Cecilia._2A.TPFinal
{
    public abstract class Universo
    {
        protected string nombre;
        protected DateTime fechaEstreno;
        protected List<Personaje> listaDePersonajes;

        #region constructores

        protected Universo()
        {
            this.listaDePersonajes = new List<Personaje>();
        }
        protected Universo(string nombre, DateTime fechaEstreno)
            :this()
        {
            this.nombre = nombre;
            this.fechaEstreno = fechaEstreno;

        }
        protected Universo(string nombre, DateTime fechaEstreno, Personaje personaje)
            : this()
        {
            this.nombre = nombre;
            this.fechaEstreno = fechaEstreno;
            listaDePersonajes.Add(personaje);
        }

        #endregion

        #region metodos

        /// <summary>
        /// Metodo que muestra el objeto
        /// </summary>
        /// <returns>El contenido del objeto como un string</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( this.nombre);
            sb.AppendLine(" Estreno: " + this.fechaEstreno.ToShortDateString());
            sb.AppendLine("Personajes: ");
            foreach (Personaje item in this.listaDePersonajes)
            {
                if (item is not null)
                {
                    sb.AppendLine(item.ToString());

                }
            }
            return sb.ToString();
        }

        #endregion
    }
}
