namespace SistemaMedico.Medicos
{
    partial class HistorialPaciente
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
            this.gridDiagnostico = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(157, 42);
            this.txtDniPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(210, 23);
            this.txtDniPaciente.TabIndex = 59;
            this.toolTip1.SetToolTip(this.txtDniPaciente, "Ingrese el DNI del Paciente");
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.SystemColors.Control;
            this.lblDNI.Location = new System.Drawing.Point(59, 45);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(75, 15);
            this.lblDNI.TabIndex = 58;
            this.lblDNI.Text = "DNI Paciente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(391, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 25);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "click para buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridDiagnostico
            // 
            this.gridDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiagnostico.Location = new System.Drawing.Point(62, 88);
            this.gridDiagnostico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridDiagnostico.Name = "gridDiagnostico";
            this.gridDiagnostico.Size = new System.Drawing.Size(416, 294);
            this.gridDiagnostico.TabIndex = 56;
            // 
            // HistorialPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 439);
            this.Controls.Add(this.txtDniPaciente);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gridDiagnostico);
            this.Name = "HistorialPaciente";
            this.Text = "HistorialPaciente";
            this.Load += new System.EventHandler(this.HistorialPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtDniPaciente;
        private Label lblDNI;
        private Button btnBuscar;
        private DataGridView gridDiagnostico;
        private ToolTip toolTip1;
    }
}