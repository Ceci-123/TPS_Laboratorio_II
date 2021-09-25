
namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbEleccion = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCnvBinario = new System.Windows.Forms.Button();
            this.btnCnvDec = new System.Windows.Forms.Button();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnOperar.Location = new System.Drawing.Point(42, 212);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(90, 25);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnCerrar.Location = new System.Drawing.Point(350, 212);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 25);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbEleccion
            // 
            this.cmbEleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEleccion.FormattingEnabled = true;
            this.cmbEleccion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbEleccion.Location = new System.Drawing.Point(184, 115);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.Size = new System.Drawing.Size(121, 23);
            this.cmbEleccion.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnLimpiar.Location = new System.Drawing.Point(199, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 25);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCnvBinario
            // 
            this.btnCnvBinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnCnvBinario.Location = new System.Drawing.Point(42, 277);
            this.btnCnvBinario.Name = "btnCnvBinario";
            this.btnCnvBinario.Size = new System.Drawing.Size(170, 25);
            this.btnCnvBinario.TabIndex = 7;
            this.btnCnvBinario.Text = "Convertir a Binario";
            this.btnCnvBinario.UseVisualStyleBackColor = false;
            this.btnCnvBinario.Click += new System.EventHandler(this.btnCnvBinario_Click);
            // 
            // btnCnvDec
            // 
            this.btnCnvDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnCnvDec.Location = new System.Drawing.Point(270, 277);
            this.btnCnvDec.Name = "btnCnvDec";
            this.btnCnvDec.Size = new System.Drawing.Size(170, 25);
            this.btnCnvDec.TabIndex = 8;
            this.btnCnvDec.Text = "Convertir a Decimal";
            this.btnCnvDec.UseVisualStyleBackColor = false;
            this.btnCnvDec.Click += new System.EventHandler(this.btnCnvDec_Click);
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.lstOperaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 22;
            this.lstOperaciones.Location = new System.Drawing.Point(474, 12);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(213, 290);
            this.lstOperaciones.TabIndex = 0;
            this.lstOperaciones.SelectedIndexChanged += new System.EventHandler(this.lstOperaciones_SelectedIndexChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(184, 38);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultado.Size = new System.Drawing.Size(256, 22);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "label1";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.txtNumero1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.Location = new System.Drawing.Point(42, 115);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 29);
            this.txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.txtNumero2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.Location = new System.Drawing.Point(340, 115);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 29);
            this.txtNumero2.TabIndex = 3;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(237)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(699, 341);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.btnCnvDec);
            this.Controls.Add(this.btnCnvBinario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbEleccion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Cecilia Calanna del curso 2° A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbEleccion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCnvBinario;
        private System.Windows.Forms.Button btnCnvDec;
        private System.Windows.Forms.ListBox lstOperaciones;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
    }
}

