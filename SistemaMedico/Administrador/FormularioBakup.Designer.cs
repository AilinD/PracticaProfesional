using System;

namespace UI.Administrador
{
    partial class FormularioBakup
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.txtUbic = new System.Windows.Forms.TextBox();
            this.cboxBackup = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(214, 248);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 27);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Click para realizar el restore de la base");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(56, 188);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(432, 27);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(404, 48);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(84, 25);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Location = new System.Drawing.Point(52, 54);
            this.lblGuardar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(71, 15);
            this.lblGuardar.TabIndex = 5;
            this.lblGuardar.Text = "Guardar en :";
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(52, 119);
            this.lblSeleccionar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(111, 15);
            this.lblSeleccionar.TabIndex = 6;
            this.lblSeleccionar.Text = "Seleccione la base : ";
            // 
            // txtUbic
            // 
            this.txtUbic.Location = new System.Drawing.Point(136, 51);
            this.txtUbic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUbic.Name = "txtUbic";
            this.txtUbic.Size = new System.Drawing.Size(237, 23);
            this.txtUbic.TabIndex = 7;
            // 
            // cboxBackup
            // 
            this.cboxBackup.FormattingEnabled = true;
            this.cboxBackup.Location = new System.Drawing.Point(200, 115);
            this.cboxBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxBackup.Name = "cboxBackup";
            this.cboxBackup.Size = new System.Drawing.Size(288, 23);
            this.cboxBackup.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormularioBakup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 305);
            this.Controls.Add(this.cboxBackup);
            this.Controls.Add(this.txtUbic);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormularioBakup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Backup";
            this.Load += new System.EventHandler(this.FormularioBakup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.TextBox txtUbic;
        private System.Windows.Forms.ComboBox cboxBackup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
    }
}