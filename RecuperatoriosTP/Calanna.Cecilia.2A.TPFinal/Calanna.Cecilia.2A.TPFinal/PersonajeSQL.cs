using System;
using System.Xml.Serialization;

namespace Calanna.Cecilia._2A.TPFinal
{
    
    public delegate void EventoNota(object sender, EventArgs e);
    public class PersonajeSQL : Persona
    {
        private double pochoclosCalificacion;

        [XmlIgnore]
        public EventoNota Buena;
        [XmlIgnore]
        public EventoNota Mala;
        [XmlIgnore]
        public EventoNota Super;

        public PersonajeSQL()
        {
        }
        public PersonajeSQL(string apellido, string nombre, int dni, double pochoclosCalificacion) : base(apellido, nombre, dni)
        {
            this.PochoclosCalificacion = pochoclosCalificacion;
        }

        public double PochoclosCalificacion
        {
            get
            {
                return this.pochoclosCalificacion;
            }
            set
            {
                if (value > 0 && value < 11)
                {
                    this.pochoclosCalificacion = value;
                }
            }
        }

        public void Clasificar()
        {
            if (this.PochoclosCalificacion < 4)
            {
                Mala.Invoke(this, EventArgs.Empty);
            }
            else if (this.PochoclosCalificacion < 6 && this.PochoclosCalificacion > 3)
            {
                Buena.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Super.Invoke(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" calificacion: {this.pochoclosCalificacion} pochoclos\n";
        }
    }
}