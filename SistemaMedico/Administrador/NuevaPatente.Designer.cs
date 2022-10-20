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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.cboxFamiliaPatente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(89, 148);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblNombrePatente
            // 
            this.lblNombrePatente.AutoSize = true;
            this.lblNombrePatente.Location = new System.Drawing.Point(36, 52);
            this.lblNombrePatente.Name = "lblNombrePatente";
            this.lblNombrePatente.Size = new System.Drawing.Size(84, 13);
            this.lblNombrePatente.TabIndex = 1;
            this.lblNombrePatente.Text = "Nombre Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Familia Patente";
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(126, 49);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePatente.TabIndex = 3;
            // 
            // cboxFamiliaPatente
            // 
            this.cboxFamiliaPatente.FormattingEnabled = true;
            this.cboxFamiliaPatente.Location = new System.Drawing.Point(126, 93);
            this.cboxFamiliaPatente.Name = "cboxFamiliaPatente";
            this.cboxFamiliaPatente.Size = new System.Drawing.Size(100, 21);
            this.cboxFamiliaPatente.TabIndex = 4;
            // 
            // NuevaPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 203);
            this.Controls.Add(this.cboxFamiliaPatente);
            this.Controls.Add(this.txtNombrePatente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombrePatente);
            this.Controls.Add(this.btnGenerar);
            this.Name = "NuevaPatente";
            this.Text = "NuevaPatente";
            this.Load += new System.EventHandler(this.NuevaPatente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblNombrePatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.ComboBox cboxFamiliaPatente;
    }
}