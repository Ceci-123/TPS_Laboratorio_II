using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace Calanna.Cecilia._2A.TPFinal
{
    public class Pelicula : Universo , ISaga
    {
        protected int numeroDeFase;

        #region constructores
        /// <summary>
        /// Constructor sin parametros solo para uso del serialize
        /// </summary>
        public Pelicula()
        {
            
        }
        public Pelicula(string nombre, DateTime fechaEstreno, int numeroFase)
            :base(nombre, fechaEstreno)
        {
            this.numeroDeFase = numeroFase;    
        }

        public Pelicula(string nombre, DateTime fechaEstreno, int numeroFase, Personaje personaje)
            : base(nombre, fechaEstreno, personaje)
        {
            this.numeroDeFase = numeroFase;
        }
        #endregion

        #region sobrecarga de operadores

        /// <summary>
        /// Sobrecarga del operador ==, si un personaje esta en una pelicula
        /// </summary>
        /// <param name="peli"></param>
        /// <param name="pje"></param>
        /// <returns>Un booleano</returns>
        public static bool operator ==(Pelicula peli, Personaje pje)
        {
            bool respuesta = false;
            if (peli is not null && pje is not null)
            {
                foreach (Personaje item in peli.listaDePersonajes)
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
        /// Sobrecarga del operador !=, si un personaje no esta en una pelicula
        /// </summary>
        /// <param name="peli"></param>
        /// <param name="pje"></param>
        /// <returns>Un booleano</returns>
        public static bool operator !=(Pelicula peli, Personaje pje)
        {
            return !(peli == pje);
        }

        /// <summary>
        /// Sobrecarga del operador + agrega un personaje a la pelicula
        /// </summary>
        /// <param name="peli"></param>
        /// <param name="pje"></param>
        /// <returns></returns>
        public static Pelicula operator +(Pelicula peli, Personaje pje)
        {
            if (peli is not null && pje is not null)
            {
                if(!(peli == pje))
                {
                   peli.listaDePersonajes.Add(pje);

                }
            }
            return peli;
        }

        /// <summary>
        /// Override para quitar el warning
        /// </summary>
        /// <returns>Un entero con el hash</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Override del equals para quitar el warning
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Un booleano</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion

        #region metodos

        /// <summary>
        /// Devuelve el numero de fase de la pelicula, validado
        /// </summary>
        /// <param name="unaPelicula"></param>
        /// <returns>Un entero, el numero de fase</returns>
        public int DevolverFase(Pelicula unaPelicula)
        {
           if(!ValidarFase(unaPelicula.numeroDeFase))
            {
                throw new FaseInvalidaException("fase invalida");
            }
           return unaPelicula.NumeroDeFase;
            
        }

        /// <summary>
        /// Muestra los datos de una pelicula
        /// </summary>
        /// <returns>Una cadena con los datos de la pelicula</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(" Numero de fase: " + this.numeroDeFase);
            return sb.ToString();
        }

        /// <summary>
        /// Override de To String
        /// </summary>
        /// <returns>Los datos de la pelicula</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Valida que la fase este dentro de los parametros correctos
        /// </summary>
        /// <param name="faseIngresada"></param>
        /// <returns>Un booleano</returns>
        public static bool ValidarFase(int faseIngresada)
        {
            bool retorno = false;
            if(faseIngresada > 0 && faseIngresada < 5)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Exporta una lista de peliculas a un archivo de texto
        /// </summary>
        /// <param name="lista"></param>
        public static void ExportarATxt(List<Pelicula> lista)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\carpetaDePrueba";
            if (!Directory.Exists(ruta))
            {
                try
                {
                    Directory.CreateDirectory(ruta);
                }

                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            try
            {
                ruta += "\\"+ DateTime.Now.ToString("HH_mm_ss") + ".txt";

                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    writer.WriteLine("Universo De Marvel");
                    foreach (Pelicula item in lista)
                    {
                        writer.WriteLine(item.Mostrar());
                    }
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }

        /// <summary>
        /// Exporta una lista de peliculas a un archivo con formato csv
        /// </summary>
        /// <param name="lista"></param>
        public static void ExportarACsv(List<Pelicula> lista)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\carpetaDePrueba";
            if (!Directory.Exists(ruta))
            {
                try
                {
                    Directory.CreateDirectory(ruta);
                }

                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            try
            {
                ruta += "\\" + DateTime.Now.ToString("HH_mm_ss") + ".csv";

                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    writer.WriteLine("Universo De Marvel");
                    writer.WriteLine("{Nombre};{fechaestreno};{fase}") ;
                    foreach (Pelicula item in lista)
                    {
                        //writer.Write(item.nombre +","+ item.fechaEstreno +","+ item.numeroDeFase);
                        writer.Write($"{item.nombre};{ item.fechaEstreno};{ item.numeroDeFase}");
                        writer.Write(item.listaDePersonajes);
                        writer.WriteLine();
                    }
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }

        #endregion

        #region (getters y setters) props

        public int NumeroDeFase
        {
            get { return numeroDeFase; }
            set { numeroDeFase = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime Fecha
        {
            get { return fechaEstreno; }
            set { fechaEstreno = value; }
        }
        public List<Personaje> ListadoPesonajes
        {
            get { return listaDePersonajes; }
            set { listaDePersonajes = value; }
        }

        #endregion



        #region serialize

        /// <summary>
        /// Serializador de un objeto de tipo pelicula
        /// </summary>
        /// <param name="unaPelicula"></param>
        public static void SerializeNow(Pelicula unaPelicula)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter("pelicula.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pelicula));

                    xmlSerializer.Serialize(streamWriter, unaPelicula);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Des-serializador de un objeto de tipo pelicula
        /// </summary>
        /// <param name="unaPelicula"></param>
        public static void DeSerializeNow()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("pelicula.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pelicula));

                    Pelicula pelicula = xmlSerializer.Deserialize(streamReader) as Pelicula;

                    Console.WriteLine($"Nombre: {pelicula.Nombre}");
                    Console.WriteLine($"Fecha de nacimiento: {pelicula.Fecha}");
                    Console.WriteLine($"Promedio: {pelicula.NumeroDeFase}");
                    Console.WriteLine($"Promedio: {pelicula.listaDePersonajes}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
        // 

        /// <summary>
        /// Escribe en un archivo la lista de peliculas que le pasamos en el parametro lista
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Un booleano</returns>
        public static bool Escribir(ListaGeneral<Pelicula> lista)
        {
            bool rta = true;

            string path = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\marvel.log";

            if (!File.Exists(path))
            {
                try
                {
                    using (StreamWriter f = new StreamWriter(path, false))
                    {
                       
                        foreach (Pelicula item in lista.listaGeneral)
                        {
                            f.WriteLine(item.ToString() + "---");
                        }
                        
                    }
                }
                catch
                {
                    rta = false;
                }
            }
            else
            {
                try
                {
                    using (StreamWriter f = new StreamWriter(path, true))
                    {
                        f.Write("Fecha: ");
                        f.WriteLine(System.DateTime.Now);
                        f.Write("Precio Total: ");
                        f.WriteLine(lista.listaGeneral);
                        f.WriteLine("---------------------------------");
                    }
                }
                catch
                {
                    rta = false;
                }

            }


            return rta;
        }

        /// <summary>
        /// Toma el contenido del archivo pasado por parametro y lo escribe en la lista que le pasamos como segundo parametro
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Un booleano</returns>
        public static bool Leer(string archivo, out ListaGeneral<Pelicula> datos)
        {
            bool retorno = false;
            datos = default;
            try
            {
                if(archivo != null)
                {
                    using (XmlTextReader reader = new XmlTextReader(archivo)) //(@"C:\archivos\DatosLista.xml"))
                    {
                        XmlSerializer ser = new XmlSerializer((typeof(ListaGeneral<Pelicula>)));

                        datos = (ListaGeneral<Pelicula>)ser.Deserialize(reader);
                        retorno = true;
                    }
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            return retorno;
        }
        // 
    }
}
