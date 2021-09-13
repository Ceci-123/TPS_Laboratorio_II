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
        #region variables
        Operando primerOperando;
        Operando segundoOperando;
        double resultado;
        string cadena;
        string memoria = "";
        #endregion

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
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbEleccion.SelectedIndex.ToString());
            lblResultado.Text = resultado.ToString();
            EscribirHistorial();
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
            cadena = txtNumero1.Text;
            lblResultado.Text = Operando.BinarioDecimal(cadena);
            EscribirHistorialBinario();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Asigna una cadena vacia como valor de texto de los TextBox y label
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = " ";
            this.txtNumero2.Text = " ";
            this.lblResultado.Text = " ";


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
            cadena = txtNumero1.Text;
            lblResultado.Text = Operando.DecimalBinario(cadena);
            EscribirHistorialBinario();
        }

        /// <summary>
        /// Llama al metodo Operar de calculadora pasandole los parametros que necesita
        /// </summary>
        /// <param name="numero1"> primer numero ingresado</param>
        /// <param name="numero2">segundo numero ingresado</param>
        /// <param name="operador">La operacion a realizarse</param>
        /// <returns>Devuelve la devolucion del metodo Operar de calculadora</returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            primerOperando = new Operando();
            segundoOperando = new Operando();
            primerOperando.SetNumero(numero1);
            segundoOperando.SetNumero(numero2);
            char opcion;
            switch(operador)
            {
                case "0":
                    opcion = '+';
                    break;
                case "1":
                    opcion = '-';
                    break;
                case "2":
                    opcion = '*';
                    break;
                case "3":
                    opcion = '/';
                    break;
                default:
                    opcion = '+';
                    break;
            }
            return Entidades.Calculadora.Operar(primerOperando, segundoOperando, opcion);   
            
        }

        /// <summary>
        /// Escribe en el listbox el contenido de los text box txtNumero1, txtNumero2, la eleccion del combobox
        /// y el contenido del lblResultado
        /// </summary>
        private void EscribirHistorial()
        {
            memoria = txtNumero1.Text + cmbEleccion.SelectedItem.ToString() + txtNumero2.Text + " = " + lblResultado.Text + "\n";
            lstOperaciones.Items.Add(memoria);
        }

        /// <summary>
        /// Escribe en el listbox el contenido del text box txtNumero1
        /// y el contenido del lblResultado
        /// </summary>
        private void EscribirHistorialBinario()
        {
            memoria = txtNumero1.Text +  " = " + lblResultado.Text + "\n";
            lstOperaciones.Items.Add(memoria);

        }
    }
}
