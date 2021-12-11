using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calanna.Cecilia._2A.TPFinal
{
    public class Persona
    {
        public Persona()
        {

        }

        public Persona(int idPersona, string apellido, string nombre)
        {
            this.idPersona = idPersona;
            this.apellido = apellido;
            this.nombre = nombre;
        }
        private string apellido;
        private string nombre;
        private int idPersona;

        protected Persona(string nombre, string apellido, int idPersona)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.idPersona = idPersona;
        }


        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int IdPersona
        {
            get { return this.idPersona; }

            set
            {
                this.idPersona = value;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"{this.Apellido}-");
            datos.AppendLine($"{this.Nombre}-");
            datos.AppendLine($"{this.idPersona}-");

            return datos.ToString();

        }
    }
}
