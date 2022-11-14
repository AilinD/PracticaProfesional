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
            this.lbPaciente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridpaciente = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridpaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(123, 23);
            this.txtDniPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(178, 23);
            this.txtDniPaciente.TabIndex = 50;
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.lbPaciente.Location = new System.Drawing.Point(24, 26);
            this.lbPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(75, 15);
            this.lbPaciente.TabIndex = 49;
            this.lbPaciente.Text = "DNI Paciente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(336, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 25);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridpaciente
            // 
            this.gridpaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpaciente.Location = new System.Drawing.Point(24, 68);
            this.gridpaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridpaciente.Name = "gridpaciente";
            this.gridpaciente.Size = new System.Drawing.Size(399, 315);
            this.gridpaciente.TabIndex = 51;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(187, 417);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 52;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // EstudiosXPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 466);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gridpaciente);
            this.Controls.Add(this.txtDniPaciente);
            this.Controls.Add(this.lbPaciente);
            this.Controls.Add(this.btnBuscar);
            this.Name = "EstudiosXPaciente";
            this.Text = "EstudiosXPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.gridpaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDniPaciente;
        private Label lbPaciente;
        private Button btnBuscar;
        private DataGridView gridpaciente;
        private Button btnGenerar;
    }
}