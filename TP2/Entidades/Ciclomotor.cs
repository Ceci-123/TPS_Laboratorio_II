using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Ciclomotor son 'Chico'. Propiedad protected, sobreescribe la de la clase base. Solo getter.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
              return ETamanio.Chico;
            }
        }

        #region constructor
        /// <summary>
        /// Constructor de la clase, llama al constructor base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            :base(marca, chasis, color)
        {
            
        }
        #endregion
        #region metodo
        /// <summary>
        /// Muestra los datos de un ciclomotor, llama al mostrar de la clase base (override)
        /// </summary>
        /// <returns>Un string con los datos del ciclomotor</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            //sb.AppendFormat("TAMAÑO : {0}", this.Tamanio.ToString()); 
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
