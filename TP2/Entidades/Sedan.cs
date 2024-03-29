﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas
        }

        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas. Constructor llama a la clase base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
             : base( marca, chasis, color)
        {
            tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Constructor, se puede elegir el tipo, llama al constructor anterior
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
             :this(marca,chasis,color)
        {
           this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'. Propiedad protected, override de la base
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Mostrar de la clase Sedan, reutiliza codigo de la clase base
        /// </summary>
        /// <returns>Un string con los datos del sedan</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.Append(base.Mostrar());
            //sb.AppendLine(base.Mostrar());
            //sb.AppendFormat("TAMAÑO : {0}", this.Tamanio.ToString());
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
