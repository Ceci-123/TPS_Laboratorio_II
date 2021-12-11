
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
        /// </summary>btn_agregar
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstTodos = new System.Windows.Forms.ListBox();
            this.lstMalas = new System.Windows.Forms.ListBox();
            this.lstBuenas = new System.Windows.Forms.ListBox();
            this.lstSuper = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Fase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Firebrick;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(411, 34);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(330, 25);
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
            this.btn_agregar.Location = new System.Drawing.Point(25, 276);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(303, 47);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "&Agregar pelicula";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar1_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_filtrar.Location = new System.Drawing.Point(466, 276);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(110, 82);
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
            this.txt_Nombre.Size = new System.Drawing.Size(171, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // Picker_fecha
            // 
            this.Picker_fecha.CalendarFont = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Picker_fecha.CalendarMonthBackground = System.Drawing.Color.Firebrick;
            this.Picker_fecha.CalendarTitleBackColor = System.Drawing.Color.Firebrick;
            this.Picker_fecha.Font = new System.Drawing.Font("Candara", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Picker_fecha.Location = new System.Drawing.Point(157, 131);
            this.Picker_fecha.Name = "Picker_fecha";
            this.Picker_fecha.Size = new System.Drawing.Size(171, 18);
            this.Picker_fecha.TabIndex = 2;
            // 
            // cmbBx_personajes
            // 
            this.cmbBx_personajes.BackColor = System.Drawing.Color.Firebrick;
            this.cmbBx_personajes.FormattingEnabled = true;
            this.cmbBx_personajes.Location = new System.Drawing.Point(157, 167);
            this.cmbBx_personajes.Name = "cmbBx_personajes";
            this.cmbBx_personajes.Size = new System.Drawing.Size(171, 23);
            this.cmbBx_personajes.TabIndex = 3;
            // 
            // listBox_Resultados
            // 
            this.listBox_Resultados.BackColor = System.Drawing.Color.Firebrick;
            this.listBox_Resultados.FormattingEnabled = true;
            this.listBox_Resultados.ItemHeight = 15;
            this.listBox_Resultados.Location = new System.Drawing.Point(357, 90);
            this.listBox_Resultados.Name = "listBox_Resultados";
            this.listBox_Resultados.Size = new System.Drawing.Size(474, 139);
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
            this.numeric_Fase.Location = new System.Drawing.Point(157, 206);
            this.numeric_Fase.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numeric_Fase.Name = "numeric_Fase";
            this.numeric_Fase.Size = new System.Drawing.Size(171, 23);
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
            this.btn_Cerrar.Location = new System.Drawing.Point(619, 276);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(112, 82);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "&Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(861, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.Location = new System.Drawing.Point(959, 34);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.Location = new System.Drawing.Point(1059, 34);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lstTodos
            // 
            this.lstTodos.FormattingEnabled = true;
            this.lstTodos.ItemHeight = 15;
            this.lstTodos.Location = new System.Drawing.Point(6, 20);
            this.lstTodos.Name = "lstTodos";
            this.lstTodos.Size = new System.Drawing.Size(261, 109);
            this.lstTodos.TabIndex = 0;
            // 
            // lstMalas
            // 
            this.lstMalas.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMalas.ForeColor = System.Drawing.Color.Red;
            this.lstMalas.FormattingEnabled = true;
            this.lstMalas.ItemHeight = 12;
            this.lstMalas.Location = new System.Drawing.Point(6, 19);
            this.lstMalas.Name = "lstMalas";
            this.lstMalas.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstMalas.Size = new System.Drawing.Size(261, 40);
            this.lstMalas.TabIndex = 1;
            // 
            // lstBuenas
            // 
            this.lstBuenas.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBuenas.FormattingEnabled = true;
            this.lstBuenas.ItemHeight = 12;
            this.lstBuenas.Location = new System.Drawing.Point(6, 25);
            this.lstBuenas.Name = "lstBuenas";
            this.lstBuenas.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBuenas.Size = new System.Drawing.Size(261, 40);
            this.lstBuenas.TabIndex = 2;
            // 
            // lstSuper
            // 
            this.lstSuper.BackColor = System.Drawing.SystemColors.Window;
            this.lstSuper.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSuper.ForeColor = System.Drawing.Color.Blue;
            this.lstSuper.FormattingEnabled = true;
            this.lstSuper.ItemHeight = 12;
            this.lstSuper.Location = new System.Drawing.Point(6, 17);
            this.lstSuper.Name = "lstSuper";
            this.lstSuper.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstSuper.Size = new System.Drawing.Size(261, 40);
            this.lstSuper.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTodos);
            this.groupBox1.Location = new System.Drawing.Point(861, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMalas);
            this.groupBox2.Location = new System.Drawing.Point(861, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 64);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pelis Malas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstBuenas);
            this.groupBox3.Location = new System.Drawing.Point(861, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 72);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pelis Buenas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstSuper);
            this.groupBox4.Location = new System.Drawing.Point(861, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 64);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Super Pelis";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::FormularioUniverso.Properties.Resources.fondoOk;
            this.ClientSize = new System.Drawing.Size(1161, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universo Marvel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Fase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstTodos;
        private System.Windows.Forms.ListBox lstMalas;
        private System.Windows.Forms.ListBox lstBuenas;
        private System.Windows.Forms.ListBox lstSuper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;


    }
}

