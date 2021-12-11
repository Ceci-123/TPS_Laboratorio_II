using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Calanna.Cecilia._2A.TPFinal
{
    class ControladorADO
    {
        private static string connectionStr;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        public static int[] idBInventariosInformes;
        public static int[] idBInventariosDepositos;

        private static void Conectarse()
        {
            connectionStr = " Server = localhost ; Database = UniversoMarvel; Trusted_Connection = true ; ";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = conexion
            };
        }

        #region Lectura
        /// <summary>
        /// Lectura de inventarios
        /// </summary>
        /// <param name="listaInventarios"></param>
        public static void LeerInventarios(List<Pelicula> listaInventarios)
        {
            listaInventarios.Clear();
            Conectarse();
            try
            {
                Pelicula inventario;
                conexion.Open();
                comando.CommandText = "SELECT * FROM dbo.inventarios";
                SqlDataReader myReader = comando.ExecuteReader();

                while (myReader.Read())
                {
                    //inventario = new Pelicula(myReader["MARCA_PAPEL"].ToString(),
                    //                           (Pelicula.nombre  )Enum.Parse(typeof(Universo.nom    ),
                    //                           myReader["TIPO_PAPEL"].ToString()),
                    //                           Convert.ToInt32(myReader["ID_CLIENTE"]),
                    //                           Convert.ToInt32(myReader["ID_INVENTARIO"]));

                    listaInventarios.Add(inventario);
                }
                myReader.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}