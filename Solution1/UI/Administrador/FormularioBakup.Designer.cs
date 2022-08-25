using Microsoft.SqlServer.Management.Smo;
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
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtboxServidor = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtboxDB = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(133, 163);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Generar";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(27, 26);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(41, 13);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Server:";
            // 
            // txtboxServidor
            // 
            this.txtboxServidor.Location = new System.Drawing.Point(83, 23);
            this.txtboxServidor.Name = "txtboxServidor";
            this.txtboxServidor.Size = new System.Drawing.Size(225, 20);
            this.txtboxServidor.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // txtboxDB
            // 
            this.txtboxDB.Location = new System.Drawing.Point(84, 62);
            this.txtboxDB.Name = "txtboxDB";
            this.txtboxDB.Size = new System.Drawing.Size(224, 20);
            this.txtboxDB.TabIndex = 5;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(28, 65);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(56, 13);
            this.lblDB.TabIndex = 4;
            this.lblDB.Text = "Database:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ubicacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(392, 97);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(100, 20);
            this.txtubicacion.TabIndex = 7;
            // 
            // FormularioBakup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 216);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxDB);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtboxServidor);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.btnBackup);
            this.Name = "FormularioBakup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Backup";
            this.Load += new System.EventHandler(this.FormularioBakup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtboxServidor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtboxDB;
        private System.Windows.Forms.Label lblDB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtubicacion;
    }
}