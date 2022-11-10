namespace UI.Administrador
{
    partial class NNuevoUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboxPatentes = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtContra2 = new System.Windows.Forms.TextBox();
            this.lblRepitePass = new System.Windows.Forms.Label();
            this.lblSelecPat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(160, 292);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(88, 27);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(54, 63);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // cboxPatentes
            // 
            this.cboxPatentes.FormattingEnabled = true;
            this.cboxPatentes.Location = new System.Drawing.Point(196, 213);
            this.cboxPatentes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxPatentes.Name = "cboxPatentes";
            this.cboxPatentes.Size = new System.Drawing.Size(159, 23);
            this.cboxPatentes.TabIndex = 3;
            this.cboxPatentes.SelectedIndexChanged += new System.EventHandler(this.cboxPatentes_SelectedIndexChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(132, 110);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(223, 23);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(54, 113);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 15);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Contraseña";
            // 
            // txtContra2
            // 
            this.txtContra2.Location = new System.Drawing.Point(172, 160);
            this.txtContra2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.Size = new System.Drawing.Size(184, 23);
            this.txtContra2.TabIndex = 7;
            // 
            // lblRepitePass
            // 
            this.lblRepitePass.AutoSize = true;
            this.lblRepitePass.Location = new System.Drawing.Point(54, 164);
            this.lblRepitePass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepitePass.Name = "lblRepitePass";
            this.lblRepitePass.Size = new System.Drawing.Size(103, 15);
            this.lblRepitePass.TabIndex = 6;
            this.lblRepitePass.Text = "Repita Contraseña";
            // 
            // lblSelecPat
            // 
            this.lblSelecPat.AutoSize = true;
            this.lblSelecPat.Location = new System.Drawing.Point(54, 217);
            this.lblSelecPat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecPat.Name = "lblSelecPat";
            this.lblSelecPat.Size = new System.Drawing.Size(110, 15);
            this.lblSelecPat.TabIndex = 8;
            this.lblSelecPat.Text = "Seleccionar Patente";
            // 
            // NNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 342);
            this.Controls.Add(this.lblSelecPat);
            this.Controls.Add(this.txtContra2);
            this.Controls.Add(this.lblRepitePass);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.cboxPatentes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGenerar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NNuevoUsuario";
            this.Text = "NNuevoUsuario";
            this.Load += new System.EventHandler(this.NNuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboxPatentes;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtContra2;
        private System.Windows.Forms.Label lblRepitePass;
        private System.Windows.Forms.Label lblSelecPat;
    }
}