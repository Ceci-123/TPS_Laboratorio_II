using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        Operando primerOperando;
        Operando segundoOperando;
        double resultado;
        int seleccion;
        
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            primerOperando = new Operando();
            segundoOperando = new Operando();
            primerOperando.SetNumero(txtIngreso1.Text);
            segundoOperando.SetNumero(txtIngreso2.Text);
            seleccion = cmbEleccion.SelectedIndex;
            resultado = Entidades.Calculadora.Operar(primerOperando, segundoOperando, Entidades.Calculadora.Conversor(seleccion));
            txtResultado.Text = resultado.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro?");
        }
    }
}
