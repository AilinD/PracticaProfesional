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
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevoContacto
            // 
            this.txtNuevoContacto.Location = new System.Drawing.Point(137, 374);
            this.txtNuevoContacto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoContacto.Name = "txtNuevoContacto";
            this.txtNuevoContacto.Size = new System.Drawing.Size(210, 23);
            this.txtNuevoContacto.TabIndex = 43;
            // 
            // lblNuevoContacto
            // 
            this.lblNuevoContacto.AutoSize = true;
            this.lblNuevoContacto.Location = new System.Drawing.Point(33, 382);
            this.lblNuevoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoContacto.Name = "lblNuevoContacto";
            this.lblNuevoContacto.Size = new System.Drawing.Size(94, 15);
            this.lblNuevoContacto.TabIndex = 42;
            this.lblNuevoContacto.Text = "Nuevo Contacto";
            // 
            // txtNuevoDomicilio
            // 
            this.txtNuevoDomicilio.Location = new System.Drawing.Point(137, 336);
            this.txtNuevoDomicilio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoDomicilio.Name = "txtNuevoDomicilio";
            this.txtNuevoDomicilio.Size = new System.Drawing.Size(210, 23);
            this.txtNuevoDomicilio.TabIndex = 41;
            // 
            // lblNuevoDomicilio
            // 
            this.lblNuevoDomicilio.AutoSize = true;
            this.lblNuevoDomicilio.Location = new System.Drawing.Point(33, 339);
            this.lblNuevoDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoDomicilio.Name = "lblNuevoDomicilio";
            this.lblNuevoDomicilio.Size = new System.Drawing.Size(96, 15);
            this.lblNuevoDomicilio.TabIndex = 40;
            this.lblNuevoDomicilio.Text = "Nuevo Domicilio";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(372, 370);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 27);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(132, 44);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(215, 23);
            this.txtNombrePaciente.TabIndex = 37;
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(25, 47);
            this.lblApellidoPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(96, 15);
            this.lblApellidoPaciente.TabIndex = 36;
            this.lblApellidoPaciente.Text = "ApellidoPaciente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(372, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 216);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ModificaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.Controls.Add(this.txtNuevoContacto);
            this.Controls.Add(this.lblNuevoContacto);
            this.Controls.Add(this.txtNuevoDomicilio);
            this.Controls.Add(this.lblNuevoDomicilio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lblApellidoPaciente);
            this.Controls.Add(this.btnBuscar);
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
        private Button btnModificar;
        private TextBox txtNombrePaciente;
        private Label lblApellidoPaciente;
        private Button btnBuscar;
        private DataGridView dataGridView1;
    }
}