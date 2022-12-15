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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboxPatentes = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtContra2 = new System.Windows.Forms.TextBox();
            this.lblRepitePass = new System.Windows.Forms.Label();
            this.lblSelecPat = new System.Windows.Forms.Label();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.lblIdRol = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(144, 298);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 27);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Generar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Click para generar usuario");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 42);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 39);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 23);
            this.txtNombre.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNombre, "Ingrese nombre del usuario");
            // 
            // cboxPatentes
            // 
            this.cboxPatentes.FormattingEnabled = true;
            this.cboxPatentes.Location = new System.Drawing.Point(177, 189);
            this.cboxPatentes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxPatentes.Name = "cboxPatentes";
            this.cboxPatentes.Size = new System.Drawing.Size(159, 23);
            this.cboxPatentes.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboxPatentes, "Seleccione la patente del nuevo usuario");
            this.cboxPatentes.SelectedIndexChanged += new System.EventHandler(this.cboxPatentes_SelectedIndexChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(113, 86);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(223, 23);
            this.txtContraseña.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtContraseña, "Ingrese contraseña del usuario");
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(35, 89);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 15);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Contraseña";
            // 
            // txtContra2
            // 
            this.txtContra2.Location = new System.Drawing.Point(153, 136);
            this.txtContra2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.Size = new System.Drawing.Size(184, 23);
            this.txtContra2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtContra2, "repita la contraseña ");
            // 
            // lblRepitePass
            // 
            this.lblRepitePass.AutoSize = true;
            this.lblRepitePass.Location = new System.Drawing.Point(35, 140);
            this.lblRepitePass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepitePass.Name = "lblRepitePass";
            this.lblRepitePass.Size = new System.Drawing.Size(103, 15);
            this.lblRepitePass.TabIndex = 6;
            this.lblRepitePass.Text = "Repita Contraseña";
            // 
            // lblSelecPat
            // 
            this.lblSelecPat.AutoSize = true;
            this.lblSelecPat.Location = new System.Drawing.Point(35, 193);
            this.lblSelecPat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecPat.Name = "lblSelecPat";
            this.lblSelecPat.Size = new System.Drawing.Size(110, 15);
            this.lblSelecPat.TabIndex = 8;
            this.lblSelecPat.Text = "Seleccionar Patente";
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(113, 239);
            this.txtIdRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(238, 23);
            this.txtIdRol.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtIdRol, "Ingrese el numero del rol del usuario de la tabla medico");
            this.txtIdRol.TextChanged += new System.EventHandler(this.txtIdRol_TextChanged);
            // 
            // lblIdRol
            // 
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Location = new System.Drawing.Point(35, 242);
            this.lblIdRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(34, 15);
            this.lblIdRol.TabIndex = 9;
            this.lblIdRol.Text = "IdRol";
            this.lblIdRol.Click += new System.EventHandler(this.lblIdRol_Click);
            // 
            // NNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 356);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.lblIdRol);
            this.Controls.Add(this.lblSelecPat);
            this.Controls.Add(this.txtContra2);
            this.Controls.Add(this.lblRepitePass);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.cboxPatentes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NNuevoUsuario";
            this.Text = "NNuevoUsuario";
            this.Load += new System.EventHandler(this.NNuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboxPatentes;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtContra2;
        private System.Windows.Forms.Label lblRepitePass;
        private System.Windows.Forms.Label lblSelecPat;
        private TextBox txtIdRol;
        private Label lblIdRol;
        private ToolTip toolTip1;
    }
}