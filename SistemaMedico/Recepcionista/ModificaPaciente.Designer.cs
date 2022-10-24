namespace UI.Recepcionista
{
    partial class ModificaPaciente
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
            this.txtNuevoContacto = new System.Windows.Forms.TextBox();
            this.lblNuevoContacto = new System.Windows.Forms.Label();
            this.txtNuevoDomicilio = new System.Windows.Forms.TextBox();
            this.lblNuevoDomicilio = new System.Windows.Forms.Label();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscaPaciente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevoContacto
            // 
            this.txtNuevoContacto.Location = new System.Drawing.Point(580, 148);
            this.txtNuevoContacto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoContacto.Name = "txtNuevoContacto";
            this.txtNuevoContacto.PasswordChar = '*';
            this.txtNuevoContacto.Size = new System.Drawing.Size(116, 23);
            this.txtNuevoContacto.TabIndex = 43;
            // 
            // lblNuevoContacto
            // 
            this.lblNuevoContacto.AutoSize = true;
            this.lblNuevoContacto.Location = new System.Drawing.Point(449, 156);
            this.lblNuevoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoContacto.Name = "lblNuevoContacto";
            this.lblNuevoContacto.Size = new System.Drawing.Size(94, 15);
            this.lblNuevoContacto.TabIndex = 42;
            this.lblNuevoContacto.Text = "Nuevo Contacto";
            // 
            // txtNuevoDomicilio
            // 
            this.txtNuevoDomicilio.Location = new System.Drawing.Point(580, 110);
            this.txtNuevoDomicilio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoDomicilio.Name = "txtNuevoDomicilio";
            this.txtNuevoDomicilio.Size = new System.Drawing.Size(116, 23);
            this.txtNuevoDomicilio.TabIndex = 41;
            // 
            // lblNuevoDomicilio
            // 
            this.lblNuevoDomicilio.AutoSize = true;
            this.lblNuevoDomicilio.Location = new System.Drawing.Point(449, 113);
            this.lblNuevoDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoDomicilio.Name = "lblNuevoDomicilio";
            this.lblNuevoDomicilio.Size = new System.Drawing.Size(96, 15);
            this.lblNuevoDomicilio.TabIndex = 40;
            this.lblNuevoDomicilio.Text = "Nuevo Domicilio";
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.Location = new System.Drawing.Point(555, 244);
            this.btnModificarPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(88, 27);
            this.btnModificarPaciente.TabIndex = 38;
            this.btnModificarPaciente.Text = "Modificar";
            this.btnModificarPaciente.UseVisualStyleBackColor = true;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(129, 44);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(179, 23);
            this.txtNombrePaciente.TabIndex = 37;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(25, 47);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 15);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Nombre Paciente";
            // 
            // btnBuscaPaciente
            // 
            this.btnBuscaPaciente.Location = new System.Drawing.Point(433, 47);
            this.btnBuscaPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaPaciente.Name = "btnBuscaPaciente";
            this.btnBuscaPaciente.Size = new System.Drawing.Size(88, 27);
            this.btnBuscaPaciente.TabIndex = 35;
            this.btnBuscaPaciente.Text = "Buscar";
            this.btnBuscaPaciente.UseVisualStyleBackColor = true;
            this.btnBuscaPaciente.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 216);
            this.dataGridView1.TabIndex = 34;
            // 
            // ModificaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 342);
            this.Controls.Add(this.txtNuevoContacto);
            this.Controls.Add(this.lblNuevoContacto);
            this.Controls.Add(this.txtNuevoDomicilio);
            this.Controls.Add(this.lblNuevoDomicilio);
            this.Controls.Add(this.btnModificarPaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscaPaciente);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ModificaPaciente";
            this.Text = "ModificaPaciente";
            this.Load += new System.EventHandler(this.ModificaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNuevoContacto;
        private Label lblNuevoContacto;
        private TextBox txtNuevoDomicilio;
        private Label lblNuevoDomicilio;
        private Button btnModificarPaciente;
        private TextBox txtNombrePaciente;
        private Label lblUsuario;
        private Button btnBuscaPaciente;
        private DataGridView dataGridView1;
    }
}