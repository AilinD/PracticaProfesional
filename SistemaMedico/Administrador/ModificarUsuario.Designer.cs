namespace UI.Administrador
{
    partial class ModificarUsuario
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDescriptivo = new System.Windows.Forms.Label();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevaPass = new System.Windows.Forms.Label();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(463, 237);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 27);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificarUS_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(131, 44);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(179, 23);
            this.txtNombreUsuario.TabIndex = 23;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(27, 47);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(94, 15);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Nombre Usuario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(341, 40);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 173);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblDescriptivo
            // 
            this.lblDescriptivo.Location = new System.Drawing.Point(460, 10);
            this.lblDescriptivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptivo.Name = "lblDescriptivo";
            this.lblDescriptivo.Size = new System.Drawing.Size(117, 85);
            this.lblDescriptivo.TabIndex = 29;
            this.lblDescriptivo.Text = "Si no indica el Id del usuario por defecto traera todos los registros ";
            this.lblDescriptivo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(357, 106);
            this.lblNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(89, 15);
            this.lblNuevoNombre.TabIndex = 30;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(488, 103);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(116, 23);
            this.txtNuevoNombre.TabIndex = 31;
            // 
            // lblNuevaPass
            // 
            this.lblNuevaPass.AutoSize = true;
            this.lblNuevaPass.Location = new System.Drawing.Point(357, 149);
            this.lblNuevaPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaPass.Name = "lblNuevaPass";
            this.lblNuevaPass.Size = new System.Drawing.Size(104, 15);
            this.lblNuevaPass.TabIndex = 32;
            this.lblNuevaPass.Text = "Nueva Contraseña";
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Location = new System.Drawing.Point(488, 141);
            this.txtNuevaPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.PasswordChar = '*';
            this.txtNuevaPass.Size = new System.Drawing.Size(116, 23);
            this.txtNuevaPass.TabIndex = 33;
            this.txtNuevaPass.TextChanged += new System.EventHandler(this.txtNuevaPass_TextChanged);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 298);
            this.Controls.Add(this.txtNuevaPass);
            this.Controls.Add(this.lblNuevaPass);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.lblDescriptivo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ModificarUsuario";
            this.Text = "Modifica Usuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDescriptivo;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lblNuevaPass;
        private System.Windows.Forms.TextBox txtNuevaPass;
    }
}