namespace SistemaMedico.Reportes
{
    partial class EstudiosXPaciente
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
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtNombreArch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(129, 45);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(227, 23);
            this.txtDniPaciente.TabIndex = 1;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(48, 48);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(75, 15);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI Paciente";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(149, 181);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(48, 110);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(95, 15);
            this.lblArchivo.TabIndex = 6;
            this.lblArchivo.Text = "Nombre Archivo";
            // 
            // txtNombreArch
            // 
            this.txtNombreArch.Location = new System.Drawing.Point(149, 107);
            this.txtNombreArch.Name = "txtNombreArch";
            this.txtNombreArch.Size = new System.Drawing.Size(207, 23);
            this.txtNombreArch.TabIndex = 5;
            // 
            // EstudiosXPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 251);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.txtNombreArch);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDniPaciente);
            this.Name = "EstudiosXPaciente";
            this.Text = "EstudiosXPaciente";
            this.Load += new System.EventHandler(this.EstudiosXPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtDniPaciente;
        private Label lblDNI;
        private Button btnGenerar;
        private Label lblArchivo;
        private TextBox txtNombreArch;
    }
}