using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calanna.Cecilia._2A.TPFinal;

namespace FormularioUniverso
{
    public partial class FrmSecundario : Form
    {
        ListaGeneral<Pelicula> listadoActual = new ListaGeneral<Pelicula>();
        public FrmSecundario() 
        {
           InitializeComponent();
        }
        public FrmSecundario(ListaGeneral<Pelicula> listado)
        {
            InitializeComponent();
            try
            {
                this.listadoActual = listado;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
               
            }
            
        }

        private void FrmSecundario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_InfoFase1_Click(object sender, EventArgs e)
        {
            List<Pelicula> listaFiltrada = new List<Pelicula>();
            
            try
            {
                foreach (Pelicula item in listadoActual.listaGeneral)
                {
                    if (item.NumeroDeFase == 1)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                Pelicula.ExportarATxt(listaFiltrada);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo");
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }

        private void btn_InfoFase2_Click(object sender, EventArgs e)
        {
            List<Pelicula> listaFiltrada = new List<Pelicula>();
           
            try
            {
                foreach (Pelicula item in listadoActual.listaGeneral)
                {
                    if (item.NumeroDeFase == 2)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                Pelicula.ExportarATxt(listaFiltrada);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo");
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }

        private void btn_infoFase3_Click(object sender, EventArgs e)
        {
            List<Pelicula> listaFiltrada = new List<Pelicula>();
            
            try
            {
                foreach (Pelicula item in listadoActual.listaGeneral)
                {
                    if (item.NumeroDeFase == 3)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                Pelicula.ExportarATxt(listaFiltrada);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo");
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }

        private void btn_infoFase4_Click(object sender, EventArgs e)
        {
            List<Pelicula> listaFiltrada = new List<Pelicula>();
            
            try
            {
                foreach (Pelicula item in listadoActual.listaGeneral)
                {
                    if (item.NumeroDeFase == 4)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                Pelicula.ExportarATxt(listaFiltrada);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo");
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }

        private void btn_Info_IronMan_Click(object sender, EventArgs e)
        {
            List<Pelicula> listaFiltrada = new List<Pelicula>();
            Personaje im = new Personaje("Iron Man", "Tony Stark");
            
            try
            {
                foreach (Pelicula item in listadoActual.listaGeneral)
                {
                    if (item == im)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                Pelicula.ExportarATxt(listaFiltrada);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo");
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }

        private void btn_Info_Spider_Click(object sender, EventArgs e)
        {
            List<Pelicula> listaFiltrada = new List<Pelicula>();
            Personaje pp = new Personaje("Spiderman", "Peter Parker");
            
            try
            {
                foreach (Pelicula item in listadoActual.listaGeneral)
                {
                    if (item == pp)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                Pelicula.ExportarATxt(listaFiltrada);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo");
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }

        private void btn_YaEstrenadas_Click(object sender, EventArgs e)
        {
            List<Pelicula> listaFiltrada = new List<Pelicula>();
           
            
            try
            {
                foreach (Pelicula item in listadoActual.listaGeneral)
                {
                    if (DateTime.Compare(DateTime.Now, item.Fecha) > 0)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                Pelicula.ExportarATxt(listaFiltrada);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo");
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }

        private void btn_InfoFuturas_Click(object sender, EventArgs e)
        {
            List<Pelicula> listaFiltrada = new List<Pelicula>();

            
            try
            {
                foreach (Pelicula item in listadoActual.listaGeneral)
                {
                    if (DateTime.Compare(DateTime.Now, item.Fecha) < 0)
                    {
                        listaFiltrada.Add(item);
                    }
                }
                Pelicula.ExportarATxt(listaFiltrada);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo");
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }
    }
}
