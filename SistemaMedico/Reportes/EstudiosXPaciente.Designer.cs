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
            this.components = new System.ComponentModel.Container();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(129, 25);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(308, 23);
            this.txtDniPaciente.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDniPaciente, "Ingrese dni del paciente");
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(48, 28);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(75, 15);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI Paciente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(108, 373);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "click para buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(387, 270);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(282, 373);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.toolTip1.SetToolTip(this.btnGenerar, "Seleccione las filas en el margen izquiero de la tabla y click aqui");
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // EstudiosXPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 408);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDniPaciente);
            this.Name = "EstudiosXPaciente";
            this.Text = "EstudiosXPaciente";
            this.Load += new System.EventHandler(this.EstudiosXPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtDniPaciente;
        private Label lblDNI;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private Button btnGenerar;
        private ToolTip toolTip1;
    }
}