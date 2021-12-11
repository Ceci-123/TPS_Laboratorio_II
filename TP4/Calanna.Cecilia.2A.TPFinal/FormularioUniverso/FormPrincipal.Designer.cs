
namespace FormularioUniverso
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_personajes = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.Picker_fecha = new System.Windows.Forms.DateTimePicker();
            this.cmbBx_personajes = new System.Windows.Forms.ComboBox();
            this.listBox_Resultados = new System.Windows.Forms.ListBox();
            this.lbl_fase = new System.Windows.Forms.Label();
            this.numeric_Fase = new System.Windows.Forms.NumericUpDown();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Fase)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(411, 34);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(348, 24);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Universo Cinematografico Marvel";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_nombre.Location = new System.Drawing.Point(25, 100);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(126, 15);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre de la Pelicula ";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_fecha.Location = new System.Drawing.Point(25, 139);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(96, 15);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha de Estreno";
            // 
            // lbl_personajes
            // 
            this.lbl_personajes.AutoSize = true;
            this.lbl_personajes.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_personajes.Location = new System.Drawing.Point(25, 175);
            this.lbl_personajes.Name = "lbl_personajes";
            this.lbl_personajes.Size = new System.Drawing.Size(107, 15);
            this.lbl_personajes.TabIndex = 3;
            this.lbl_personajes.Text = "Personaje principal";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(51, 253);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(261, 47);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "&Agregar pelicula";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_filtrar.Location = new System.Drawing.Point(500, 384);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(130, 54);
            this.btn_filtrar.TabIndex = 6;
            this.btn_filtrar.Text = "&Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = false;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.Firebrick;
            this.txt_Nombre.Location = new System.Drawing.Point(157, 92);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(192, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // Picker_fecha
            // 
            this.Picker_fecha.CalendarMonthBackground = System.Drawing.Color.Firebrick;
            this.Picker_fecha.CalendarTitleBackColor = System.Drawing.Color.Firebrick;
            this.Picker_fecha.Location = new System.Drawing.Point(149, 133);
            this.Picker_fecha.Name = "Picker_fecha";
            this.Picker_fecha.Size = new System.Drawing.Size(200, 23);
            this.Picker_fecha.TabIndex = 2;
            // 
            // cmbBx_personajes
            // 
            this.cmbBx_personajes.BackColor = System.Drawing.Color.Firebrick;
            this.cmbBx_personajes.FormattingEnabled = true;
            this.cmbBx_personajes.Location = new System.Drawing.Point(157, 167);
            this.cmbBx_personajes.Name = "cmbBx_personajes";
            this.cmbBx_personajes.Size = new System.Drawing.Size(192, 23);
            this.cmbBx_personajes.TabIndex = 3;
            // 
            // listBox_Resultados
            // 
            this.listBox_Resultados.BackColor = System.Drawing.Color.Firebrick;
            this.listBox_Resultados.FormattingEnabled = true;
            this.listBox_Resultados.ItemHeight = 15;
            this.listBox_Resultados.Location = new System.Drawing.Point(369, 89);
            this.listBox_Resultados.Name = "listBox_Resultados";
            this.listBox_Resultados.Size = new System.Drawing.Size(780, 274);
            this.listBox_Resultados.TabIndex = 14;
            // 
            // lbl_fase
            // 
            this.lbl_fase.AutoSize = true;
            this.lbl_fase.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_fase.Location = new System.Drawing.Point(25, 214);
            this.lbl_fase.Name = "lbl_fase";
            this.lbl_fase.Size = new System.Drawing.Size(30, 15);
            this.lbl_fase.TabIndex = 16;
            this.lbl_fase.Text = "Fase";
            // 
            // numeric_Fase
            // 
            this.numeric_Fase.BackColor = System.Drawing.Color.Firebrick;
            this.numeric_Fase.Location = new System.Drawing.Point(229, 206);
            this.numeric_Fase.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numeric_Fase.Name = "numeric_Fase";
            this.numeric_Fase.Size = new System.Drawing.Size(120, 23);
            this.numeric_Fase.TabIndex = 4;
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.Firebrick;
            this.btn_import.Location = new System.Drawing.Point(25, 340);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(126, 47);
            this.btn_import.TabIndex = 6;
            this.btn_import.Text = "Importar desde archivo";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.Firebrick;
            this.btn_export.Location = new System.Drawing.Point(202, 340);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(126, 47);
            this.btn_export.TabIndex = 7;
            this.btn_export.Text = "Exportar a archivo";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cerrar.Location = new System.Drawing.Point(701, 384);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(113, 54);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "&Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::FormularioUniverso.Properties.Resources.fondoOk;
            this.ClientSize = new System.Drawing.Size(1161, 450);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.numeric_Fase);
            this.Controls.Add(this.lbl_fase);
            this.Controls.Add(this.listBox_Resultados);
            this.Controls.Add(this.cmbBx_personajes);
            this.Controls.Add(this.Picker_fecha);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_personajes);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universo Marvel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Fase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_personajes;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.DateTimePicker Picker_fecha;
        private System.Windows.Forms.ComboBox cmbBx_personajes;
        private System.Windows.Forms.ListBox listBox_Resultados;
        private System.Windows.Forms.Label lbl_fase;
        private System.Windows.Forms.NumericUpDown numeric_Fase;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

