using System;
using System.Linq;
using System.Windows.Forms;
using Calanna.Cecilia._2A.TPFinal;

namespace FormularioUniverso
{
    public partial class Form1 : Form
    {
        private PersonajeSQL personajeSql;

        public PersonajeSQL PersonajeSql
        {
            get { return personajeSql; }
        }

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(PersonajeSQL miPersonaje) : this()
        {
            this.txtApellido.Text = miPersonaje.Apellido;
            this.txtNombre.Text = miPersonaje.Nombre;
            this.txtIdPersona.Text = miPersonaje.IdPersona.ToString();
            this.txtNota.Text = miPersonaje.PochoclosCalificacion.ToString();
            this.txtNota.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(this.txtApellido.Text) && !string.IsNullOrWhiteSpace(this.txtNombre.Text)
                  && this.txtIdPersona.Text.All(char.IsDigit) && this.txtNota.Text.All(char.IsDigit))
            {
                this.personajeSql = new PersonajeSQL(this.txtApellido.Text, this.txtNombre.Text, int.Parse(this.txtIdPersona.Text), double.Parse(this.txtNota.Text));
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
