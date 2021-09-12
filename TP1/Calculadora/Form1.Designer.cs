
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
            this.txtVisor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnOperar.Location = new System.Drawing.Point(42, 212);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(90, 25);
            this.btnOperar.TabIndex = 5;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIngreso2
            // 
            this.txtIngreso2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtIngreso2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIngreso2.Location = new System.Drawing.Point(340, 109);
            this.txtIngreso2.Name = "txtIngreso2";
            this.txtIngreso2.Size = new System.Drawing.Size(100, 50);
            this.txtIngreso2.TabIndex = 3;
            this.txtIngreso2.Text = "";
            // 
            // txtIngreso1
            // 
            this.txtIngreso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtIngreso1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIngreso1.Location = new System.Drawing.Point(42, 109);
            this.txtIngreso1.Name = "txtIngreso1";
            this.txtIngreso1.Size = new System.Drawing.Size(100, 50);
            this.txtIngreso1.TabIndex = 0;
            this.txtIngreso1.Text = "";
            this.txtIngreso1.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(340, 12);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 50);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.Text = "";
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnCerrar.Location = new System.Drawing.Point(350, 212);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 25);
            this.btnCerrar.TabIndex = 7;
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
            this.cmbEleccion.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(157)))));
            this.btnLimpiar.Location = new System.Drawing.Point(199, 212);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 25);
            this.btnLimpiar.TabIndex = 6;
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
            this.btnCnvBinario.TabIndex = 8;
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
            this.btnCnvDec.TabIndex = 9;
            this.btnCnvDec.Text = "Convertir a Decimal";
            this.btnCnvDec.UseVisualStyleBackColor = false;
            this.btnCnvDec.Click += new System.EventHandler(this.btnCnvDec_Click);
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtVisor.Location = new System.Drawing.Point(460, 12);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(176, 288);
            this.txtVisor.TabIndex = 4;
            this.txtVisor.Text = "";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(237)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(699, 341);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.btnCnvDec);
            this.Controls.Add(this.btnCnvBinario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbEleccion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtIngreso1);
            this.Controls.Add(this.txtIngreso2);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCalculadora_FormClosed);
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
        private System.Windows.Forms.RichTextBox txtVisor;
    }
}

