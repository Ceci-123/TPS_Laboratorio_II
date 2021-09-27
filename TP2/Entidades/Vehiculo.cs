﻿using System;
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

        EMarca marca;
        string chasis;
        ConsoleColor color;

        public abstract ETamanio Tamanio { get; }//set; }

        #region constructor
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;

        }
        #endregion

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
       // protected abstract ETamanio Tamanio;
        //{
        //    get { return Tamanio; }
            
        //}

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CHASIS: {0}\r\n", this.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", this.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", this.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (v1 is null && v2 is null)
            {
                retorno = true;
            }
            else if (v1 is object && v2 is object)
            {
                //retorno = v1.chasis == v2.chasis;
                if (String.Compare(v1.chasis, v2.chasis) == 0)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (!(v1 == v2));
        }
    }
}
