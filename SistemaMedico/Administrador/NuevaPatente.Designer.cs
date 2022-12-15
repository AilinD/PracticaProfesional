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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblpatente = new System.Windows.Forms.Label();
            this.lblFamiliaPatente = new System.Windows.Forms.Label();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.cboxFamiliaPatente = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(104, 171);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 27);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Generar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Click para generar la patente");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblpatente
            // 
            this.lblpatente.AutoSize = true;
            this.lblpatente.Location = new System.Drawing.Point(42, 60);
            this.lblpatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpatente.Name = "lblpatente";
            this.lblpatente.Size = new System.Drawing.Size(94, 15);
            this.lblpatente.TabIndex = 1;
            this.lblpatente.Text = "Nombre Patente";
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
            this.toolTip1.SetToolTip(this.txtNombrePatente, "Ingrese Nombre de la patente");
            // 
            // cboxFamiliaPatente
            // 
            this.cboxFamiliaPatente.FormattingEnabled = true;
            this.cboxFamiliaPatente.Location = new System.Drawing.Point(147, 107);
            this.cboxFamiliaPatente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxFamiliaPatente.Name = "cboxFamiliaPatente";
            this.cboxFamiliaPatente.Size = new System.Drawing.Size(116, 23);
            this.cboxFamiliaPatente.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboxFamiliaPatente, "Seleccione la familia de la patente");
            // 
            // NuevaPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 234);
            this.Controls.Add(this.cboxFamiliaPatente);
            this.Controls.Add(this.txtNombrePatente);
            this.Controls.Add(this.lblFamiliaPatente);
            this.Controls.Add(this.lblpatente);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NuevaPatente";
            this.Text = "NuevaPatente";
            this.Load += new System.EventHandler(this.NuevaPatente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblpatente;
        private System.Windows.Forms.Label lblFamiliaPatente;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.ComboBox cboxFamiliaPatente;
        private ToolTip toolTip1;
    }
}