namespace SistemaMedico.Medicos
{
    partial class IngresarSintomasPaciente
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
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridPaciente = new System.Windows.Forms.DataGridView();
            this.txtSintoma = new System.Windows.Forms.TextBox();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.gridSintoma = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSintoma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(140, 43);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(179, 23);
            this.txtNombrePaciente.TabIndex = 47;
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(36, 46);
            this.lblApellidoPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(99, 15);
            this.lblApellidoPaciente.TabIndex = 46;
            this.lblApellidoPaciente.Text = "Apellido Paciente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(331, 43);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // gridPaciente
            // 
            this.gridPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPaciente.Location = new System.Drawing.Point(39, 89);
            this.gridPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridPaciente.Name = "gridPaciente";
            this.gridPaciente.Size = new System.Drawing.Size(380, 216);
            this.gridPaciente.TabIndex = 44;
            // 
            // txtSintoma
            // 
            this.txtSintoma.Location = new System.Drawing.Point(523, 43);
            this.txtSintoma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSintoma.Name = "txtSintoma";
            this.txtSintoma.Size = new System.Drawing.Size(179, 23);
            this.txtSintoma.TabIndex = 52;
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.BackColor = System.Drawing.SystemColors.Control;
            this.lblSintomas.Location = new System.Drawing.Point(449, 46);
            this.lblSintomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(55, 15);
            this.lblSintomas.TabIndex = 51;
            this.lblSintomas.Text = "sintomas";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(728, 40);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(88, 27);
            this.btnBusca.TabIndex = 50;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // gridSintoma
            // 
            this.gridSintoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSintoma.Location = new System.Drawing.Point(449, 89);
            this.gridSintoma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridSintoma.Name = "gridSintoma";
            this.gridSintoma.Size = new System.Drawing.Size(380, 216);
            this.gridSintoma.TabIndex = 49;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(388, 332);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 27);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // IngresarSintomasPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 412);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSintoma);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.gridSintoma);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lblApellidoPaciente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gridPaciente);
            this.Name = "IngresarSintomasPaciente";
            this.Text = "SintomasPaciente";
            this.Load += new System.EventHandler(this.SintomasPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSintoma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNombrePaciente;
        private Label lblApellidoPaciente;
        private Button btnBuscar;
        private DataGridView gridPaciente;
        private TextBox txtSintoma;
        private Label lblSintomas;
        private Button btnBusca;
        private DataGridView gridSintoma;
        private Button btnGuardar;
    }
}