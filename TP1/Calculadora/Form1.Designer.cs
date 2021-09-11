
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
            this.txtIngreso2 = new System.Windows.Forms.RichTextBox();
            this.txtIngreso1 = new System.Windows.Forms.RichTextBox();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbEleccion = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCnvBinario = new System.Windows.Forms.Button();
            this.btnCnvDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(42, 246);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 0;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIngreso2
            // 
            this.txtIngreso2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIngreso2.Location = new System.Drawing.Point(340, 134);
            this.txtIngreso2.Name = "txtIngreso2";
            this.txtIngreso2.Size = new System.Drawing.Size(50, 50);
            this.txtIngreso2.TabIndex = 1;
            this.txtIngreso2.Text = "";
            // 
            // txtIngreso1
            // 
            this.txtIngreso1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIngreso1.Location = new System.Drawing.Point(42, 134);
            this.txtIngreso1.Name = "txtIngreso1";
            this.txtIngreso1.Size = new System.Drawing.Size(50, 50);
            this.txtIngreso1.TabIndex = 2;
            this.txtIngreso1.Text = "";
            this.txtIngreso1.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(340, 12);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(50, 50);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(365, 258);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbEleccion
            // 
            this.cmbEleccion.FormattingEnabled = true;
            this.cmbEleccion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbEleccion.Location = new System.Drawing.Point(179, 115);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.Size = new System.Drawing.Size(121, 23);
            this.cmbEleccion.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(237, 246);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCnvBinario
            // 
            this.btnCnvBinario.Location = new System.Drawing.Point(42, 316);
            this.btnCnvBinario.Name = "btnCnvBinario";
            this.btnCnvBinario.Size = new System.Drawing.Size(163, 23);
            this.btnCnvBinario.TabIndex = 7;
            this.btnCnvBinario.Text = "Convertir a Binario";
            this.btnCnvBinario.UseVisualStyleBackColor = true;
            // 
            // btnCnvDec
            // 
            this.btnCnvDec.Location = new System.Drawing.Point(282, 302);
            this.btnCnvDec.Name = "btnCnvDec";
            this.btnCnvDec.Size = new System.Drawing.Size(142, 23);
            this.btnCnvDec.TabIndex = 8;
            this.btnCnvDec.Text = "Convertir a Decimal";
            this.btnCnvDec.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(237)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCnvDec);
            this.Controls.Add(this.btnCnvBinario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbEleccion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtIngreso1);
            this.Controls.Add(this.txtIngreso2);
            this.Controls.Add(this.btnOperar);
            this.Name = "frmCalculadora";
            this.Text = "Ceci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.RichTextBox txtIngreso2;
        private System.Windows.Forms.RichTextBox txtIngreso1;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbEleccion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCnvBinario;
        private System.Windows.Forms.Button btnCnvDec;
    }
}

