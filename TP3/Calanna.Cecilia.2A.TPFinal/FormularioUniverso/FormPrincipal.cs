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
    public partial class FormPrincipal : Form
    {
        ListaGeneral<Pelicula> listaCompleta = new ListaGeneral<Pelicula>(50);
        Pelicula pelicula1 = new Pelicula(); 

        Personaje p1 = new Personaje("Iron Man", "Tony Stark");
        Personaje p2 = new Personaje("Capitan America", "Steve Rogers");
        Personaje p3 = new Personaje("Hulk", "Bruce Banner");
        Personaje p4 = new Personaje("Scarlet Witch", "Wanda Maximoff");
        Personaje p5 = new Personaje("Vision", "Androide");
        Personaje p6 = new Personaje("Thor", "Odinson");
        Personaje p7 = new Personaje("Starlord", "Peter Queel");
        Personaje p8 = new Personaje("Ant Man", "Scott Lang");
        Personaje p9 = new Personaje("Doctor Strange", "Stephen Strange");
        Personaje p10 = new Personaje("Spiderman", "Peter Parker");
        Personaje p11 = new Personaje("Pantera Negra", "T'Challa");
        Personaje p12 = new Personaje("Capitana Marvel", "Carol Danvers");
        Personaje p13 = new Personaje("Black Widow", "Natasha Romanoff");
        Personaje p14 = new Personaje("Nick Fury", "");
        Personaje p15 = new Personaje("Loki", "Loki Laufeyson");
        Personaje p16 = new Personaje("Gamora", "");
        Personaje p17 = new Personaje("Rocket Racoon", "");
        Personaje p18 = new Personaje("Wasp", "Janet Van Dyne");
        Personaje p19 = new Personaje("Scarlet Witch","Wanda Maximoff");
        Personaje persona = null;
        //
        
        Pelicula pelicula2 = new Pelicula("Iron Man", DateTime.Parse("2 / 5 / 2008"), 1);
        Pelicula pelicula3 = new Pelicula("El increible Hulk", DateTime.Parse("13 / 6 / 2008"), 1);
        Pelicula pelicula4 = new Pelicula("Iron Man 2", DateTime.Parse("7 / 5 / 2010"), 1);
        Pelicula pelicula5 = new Pelicula("Thor", DateTime.Parse("6 / 5 / 2011"), 1);
        Pelicula pelicula6 = new Pelicula("Capitan America el primer vengador", DateTime.Parse("22 / 7 / 2011"), 1);
        Pelicula pelicula7 = new Pelicula("The avengers", DateTime.Parse("4 / 5 / 2012"), 1);
        Pelicula pelicula8 = new Pelicula("Iron Man 3", DateTime.Parse("3 / 5 / 2013"), 2);
        Pelicula pelicula9 = new Pelicula("Thor el mundo oscuro", DateTime.Parse("8 / 11 / 2013"), 2);
        //
        
        
        public void RefrescarUniverso(ListaGeneral<Pelicula> lista)
        {
            try
            {
                if(lista is not null)
                {
                    this.listBox_Resultados.Items.Clear();
                    foreach (Pelicula item in lista.listaGeneral)
                    {
                        listBox_Resultados.Items.Add(item);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            
        }
        public FormPrincipal()
        {
            InitializeComponent();
            pelicula2 += p1;
            pelicula3 += p1;
            pelicula3 += p3;
            pelicula4 += p1;
            pelicula4 += p13;
            pelicula5 += p6;
            pelicula6 += p14;
            pelicula6 += p2;
            pelicula7 += p1;
            pelicula7 += p2;
            pelicula7 += p3;
            pelicula7 += p6;
            pelicula7 += p13;
            pelicula8 += p1;
            pelicula8 += p2;
            pelicula9 += p6;
            listaCompleta.listaGeneral.Add(pelicula2);
            listaCompleta.listaGeneral.Add(pelicula3);
            listaCompleta.listaGeneral.Add(pelicula4);
            listaCompleta.listaGeneral.Add(pelicula5);
            listaCompleta.listaGeneral.Add(pelicula6);
            listaCompleta.listaGeneral.Add(pelicula7);
            listaCompleta.listaGeneral.Add(pelicula8);
            listaCompleta.listaGeneral.Add(pelicula9);
            RefrescarUniverso(listaCompleta);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
            this.cmbBx_personajes.Items.Add(p1);
            this.cmbBx_personajes.Items.Add(p2);
            this.cmbBx_personajes.Items.Add(p3);
            this.cmbBx_personajes.Items.Add(p4);
            this.cmbBx_personajes.Items.Add(p5);
            this.cmbBx_personajes.Items.Add(p6);
            this.cmbBx_personajes.Items.Add(p7);
            this.cmbBx_personajes.Items.Add(p8);
            this.cmbBx_personajes.Items.Add(p9);
            this.cmbBx_personajes.Items.Add(p10);
            this.cmbBx_personajes.Items.Add(p11);
            this.cmbBx_personajes.Items.Add(p12);
            this.cmbBx_personajes.Items.Add(p13);
            this.cmbBx_personajes.Items.Add(p14);
            this.cmbBx_personajes.Items.Add(p15);
            this.cmbBx_personajes.Items.Add(p16);
            this.cmbBx_personajes.Items.Add(p17);
            this.cmbBx_personajes.Items.Add(p18);
            this.cmbBx_personajes.Items.Add(p19);
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de salir?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rta == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txt_Nombre.Text;
                DateTime fechaEstreno = DateTime.Parse(Picker_fecha.Text);
                int fase = ((int)numeric_Fase.Value);

                switch (cmbBx_personajes.SelectedIndex)
                {

                    case 0:
                        persona = p1;
                        break;
                    case 1:
                        persona = p2;
                        break;
                    case 2:
                        persona = p3;
                        break;
                    case 3:
                        persona = p4;
                        break;
                    case 4:
                        persona = p5;
                        break;
                    case 5:
                        persona = p6;
                        break;
                    case 6:
                        persona = p7;
                        break;
                    case 7:
                        persona = p8;
                        break;
                    case 8:
                        persona = p9;
                        break;
                    case 9:
                        persona = p10;
                        break;
                    case 10:
                        persona = p11;
                        break;
                    case 11:
                        persona = p12;
                        break;
                    case 12:
                        persona = p13;
                        break;
                    case 13:
                        persona = p14;
                        break;
                    case 14:
                        persona = p15;
                        break;
                    case 15:
                        persona = p16;
                        break;
                    case 16:
                        persona = p17;
                        break;
                    case 17:
                        persona = p18;
                        break;
                    case 18:
                        persona = p19;
                        break;
                }


                if (String.IsNullOrEmpty(txt_Nombre.Text))
                {
                    throw new CamposVaciosException("Debe especificar un nombre para la pelicula");

                }
                if (fase is 0)
                {
                    throw new FaseInvalidaException("la fase es invalida");
                }
                if(persona is null)
                {
                    throw new PersonajeInvalidoException("el personaje no es valido");
                }

                Pelicula pelicula1 = new Pelicula(nombre, fechaEstreno, fase, persona);
                listaCompleta.listaGeneral.Add(pelicula1);
                RefrescarUniverso(listaCompleta);

            }
            catch (FaseInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (PersonajeInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "se ha producido un error");
            }


        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            FrmSecundario FrmSecundario = new FrmSecundario(listaCompleta);
            if (FrmSecundario.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("salio del segundo form");
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\marvel.log";
                ListaGeneral<Pelicula> listaCompleta2 = new ListaGeneral<Pelicula>(50);
                Pelicula.Leer(path, out listaCompleta);
                RefrescarUniverso(listaCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al importar archivo" + ex.Message);
            }
            MessageBox.Show("Archivo importado exitosamente");
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula.Escribir(listaCompleta);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al exportar archivo"+ ex.Message);
            }
            MessageBox.Show("Archivo exportado exitosamente");
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FormPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
