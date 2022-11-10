namespace UI.Administrador
{
    partial class NuevaPatente
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblNombrePatente = new System.Windows.Forms.Label();
            this.lblFamiliaPatente = new System.Windows.Forms.Label();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.cboxFamiliaPatente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(104, 171);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(88, 27);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblNombrePatente
            // 
            this.lblNombrePatente.AutoSize = true;
            this.lblNombrePatente.Location = new System.Drawing.Point(42, 60);
            this.lblNombrePatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePatente.Name = "lblNombrePatente";
            this.lblNombrePatente.Size = new System.Drawing.Size(94, 15);
            this.lblNombrePatente.TabIndex = 1;
            this.lblNombrePatente.Text = "Nombre Patente";
            // 
            // lblFamiliaPatente
            // 
            this.lblFamiliaPatente.AutoSize = true;
            this.lblFamiliaPatente.Location = new System.Drawing.Point(42, 107);
            this.lblFamiliaPatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFamiliaPatente.Name = "lblFamiliaPatente";
            this.lblFamiliaPatente.Size = new System.Drawing.Size(88, 15);
            this.lblFamiliaPatente.TabIndex = 2;
            this.lblFamiliaPatente.Text = "Familia Patente";
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(147, 57);
            this.txtNombrePatente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(116, 23);
            this.txtNombrePatente.TabIndex = 3;
            // 
            // cboxFamiliaPatente
            // 
            this.cboxFamiliaPatente.FormattingEnabled = true;
            this.cboxFamiliaPatente.Location = new System.Drawing.Point(147, 107);
            this.cboxFamiliaPatente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxFamiliaPatente.Name = "cboxFamiliaPatente";
            this.cboxFamiliaPatente.Size = new System.Drawing.Size(116, 23);
            this.cboxFamiliaPatente.TabIndex = 4;
            // 
            // NuevaPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 234);
            this.Controls.Add(this.cboxFamiliaPatente);
            this.Controls.Add(this.txtNombrePatente);
            this.Controls.Add(this.lblFamiliaPatente);
            this.Controls.Add(this.lblNombrePatente);
            this.Controls.Add(this.btnGenerar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NuevaPatente";
            this.Text = "NuevaPatente";
            this.Load += new System.EventHandler(this.NuevaPatente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblNombrePatente;
        private System.Windows.Forms.Label lblFamiliaPatente;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.ComboBox cboxFamiliaPatente;
    }
}