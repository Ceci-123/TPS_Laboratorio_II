using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Calanna.Cecilia._2A.TPFinal
{
    public class ADO : PersonajeSQL
    {
        static string cadena_conexion;
        static SqlConnection conexion;
        static SqlCommand comando;

        static ADO()
        {
            ADO.cadena_conexion = @"Server=ADM_06;Database=Universo;Trusted_Connection=True;";
            ADO.conexion = new SqlConnection(ADO.cadena_conexion);
            ADO.comando = new SqlCommand();
        }
        public ADO()
        { }
        public ADO(PersonajeSQL personajeSql) : base(personajeSql.Nombre, personajeSql.Apellido, personajeSql.IdPersona, personajeSql.PochoclosCalificacion)
        {
        }
        public static List<PersonajeSQL> ObtenerTodos()
        {
            List<PersonajeSQL> lista = new List<PersonajeSQL>();
            SqlDataReader lector;

            try
            {
                comando.Parameters.Clear();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM dbo.personajes ";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    PersonajeSQL item = new PersonajeSQL();

                    item.Apellido = lector["APELLIDO"].ToString();
                    item.Nombre = lector["NOMBRE"].ToString();
                    item.IdPersona = lector.GetInt32("ID_PERSONAJE");
                    item.PochoclosCalificacion = double.Parse(lector["POCHOCLOS"].ToString());

                    lista.Add(item);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message );
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return lista;
        }
        public bool Agregar(PersonajeSQL param)
        {
            bool rta = true;
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@APELLIDO", param.Apellido);
                comando.Parameters.AddWithValue("@NOMBRE", param.Nombre);
                comando.Parameters.AddWithValue("@ID_PERSONAJE", param.IdPersona);
                comando.Parameters.AddWithValue("@POCHOCLOS", param.PochoclosCalificacion);
                string sql = "INSERT INTO dbo.personajes " +
                             "VALUES(@APELLIDO,@NOMBRE,@ID_PERSONAJE,@POCHOCLOS)";
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception ex)
            {
                rta = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }


        public bool Modificar()
        {
            bool rta = true;

            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@APELLIDO", this.Apellido);
                comando.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                comando.Parameters.AddWithValue("@ID_PERSONAJE", this.IdPersona);
                comando.Parameters.AddWithValue("@POCHOCLOS", this.PochoclosCalificacion);

                string sql = "UPDATE dbo.personajes ";
                sql += "SET APELLIDO = @APELLIDO, NOMBRE = @NOMBRE, POCHOCLOS = @POCHOCLOS ";
                sql += "WHERE ID_PERSONAJE = @ID_PERSONAJE";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;
        }

        public bool Eliminar()
        {
            bool rta = true;

            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ID_PERSONAJE", this.IdPersona);

                string sql = "DELETE FROM dbo.personajes ";
                sql += "WHERE ID_PERSONAJE= @ID_PERSONAJE";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;
        }

    }
}
