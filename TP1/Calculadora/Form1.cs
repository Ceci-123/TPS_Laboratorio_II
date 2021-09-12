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
        string cadena;
        
        public frmCalculadora()
        {
            InitializeComponent();
            this.Limpiar();
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
            if(MessageBox.Show("Esta seguro que desea cerrar?", "Salir de la aplicacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void btnCnvDec_Click(object sender, EventArgs e)
        {
            cadena = txtIngreso1.Text;
            txtResultado.Text = Operando.BinarioDecimal(cadena);
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Asigna una cadena vacia como valor de texto de los RichTextBox
        /// </summary>
        private void Limpiar()
        {
            this.txtIngreso1.Text = " ";
            this.txtIngreso2.Text = " ";
            this.txtResultado.Text = " ";


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void frmCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnCnvBinario_Click(object sender, EventArgs e)
        {
            cadena = txtIngreso1.Text;
            txtResultado.Text = Operando.DecimalBinario(cadena);
        }
    }
}
