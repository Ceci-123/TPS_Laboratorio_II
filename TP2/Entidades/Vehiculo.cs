using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        /// <summary>
        /// ReadOnly: Retornará el tamaño. Propiedad protected, abstracta
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        #region constructor
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;

        }
        #endregion

        
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Un objeto casteado a string </returns>
        public virtual string Mostrar()
        {
            return (string)this;
            
        }
        /// <summary>
        /// Castea a string un objeto de tipo vehiculo
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)  
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");
            sb.AppendLine("");
            sb.AppendFormat("TAMAÑO : {0}", p.Tamanio.ToString());
            //sb.Append("");
            //sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Un booleano</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
           return (v1.chasis == v2.chasis);
           
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Un booleano</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (!(v1 == v2));
        }

        #region soluciono lo del equals y el get hash code para sacar el warning
        public override bool Equals(object obj) 
        {
            bool rta = false;

            if (obj is Vehiculo)
                rta = this == (Vehiculo)obj;

            return rta;
        }

        public override int GetHashCode() 
        {
            return base.GetHashCode();
        }
        #endregion

    }
}
