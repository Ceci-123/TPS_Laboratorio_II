﻿
namespace FormularioUniverso
{
    partial class IniciarHilos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarHilos));
            this.prbLoading = new System.Windows.Forms.ProgressBar();
            this.txtboxCarga = new System.Windows.Forms.TextBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // prbLoading
            // 
            this.prbLoading.BackColor = System.Drawing.Color.Black;
            this.prbLoading.Location = new System.Drawing.Point(24, 76);
            this.prbLoading.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prbLoading.MarqueeAnimationSpeed = 5;
            this.prbLoading.Name = "prbLoading";
            this.prbLoading.Size = new System.Drawing.Size(207, 30);
            this.prbLoading.Step = 1;
            this.prbLoading.TabIndex = 2;
            // 
            // txtboxCarga
            // 
            this.txtboxCarga.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtboxCarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxCarga.ForeColor = System.Drawing.SystemColors.Window;
            this.txtboxCarga.Location = new System.Drawing.Point(24, 77);
            this.txtboxCarga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtboxCarga.Multiline = true;
            this.txtboxCarga.Name = "txtboxCarga";
            this.txtboxCarga.ReadOnly = true;
            this.txtboxCarga.Size = new System.Drawing.Size(206, 29);
            this.txtboxCarga.TabIndex = 3;
            this.txtboxCarga.TabStop = false;
            this.txtboxCarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerLoading
            // 
            this.timerLoading.Tick += new System.EventHandler(this.TimerLoadingTick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // headerPic
            // 
            this.headerPic.ErrorImage = null;
            this.headerPic.Location = new System.Drawing.Point(24, 37);
            this.headerPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.headerPic.Name = "headerPic";
            this.headerPic.Size = new System.Drawing.Size(66, 58);
            this.headerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerPic.TabIndex = 0;
            this.headerPic.TabStop = false;
            // 
            // IniciarHilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(253, 142);
            this.Controls.Add(this.prbLoading);
            this.Controls.Add(this.txtboxCarga);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.headerPic);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "IniciarHilos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarHilos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IniciarHilos_FormClosing);
            this.Load += new System.EventHandler(this.IniciarHilos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerPic;
        private System.Windows.Forms.ProgressBar prbLoading;
        private System.Windows.Forms.TextBox txtboxCarga;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}