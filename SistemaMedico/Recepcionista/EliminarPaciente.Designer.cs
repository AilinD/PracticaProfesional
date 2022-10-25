namespace SistemaMedico.Recepcionista
{
    partial class EliminarPaciente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPacienteAEliminar = new System.Windows.Forms.TextBox();
            this.lblpatente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(405, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(248, 304);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 201);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtPacienteAEliminar
            // 
            this.txtPacienteAEliminar.Location = new System.Drawing.Point(195, 29);
            this.txtPacienteAEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPacienteAEliminar.Name = "txtPacienteAEliminar";
            this.txtPacienteAEliminar.Size = new System.Drawing.Size(179, 23);
            this.txtPacienteAEliminar.TabIndex = 11;
            // 
            // lblpatente
            // 
            this.lblpatente.AutoSize = true;
            this.lblpatente.Location = new System.Drawing.Point(91, 33);
            this.lblpatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpatente.Name = "lblpatente";
            this.lblpatente.Size = new System.Drawing.Size(99, 15);
            this.lblpatente.TabIndex = 10;
            this.lblpatente.Text = "Nombre Paciente";
            // 
            // EliminarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 382);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPacienteAEliminar);
            this.Controls.Add(this.lblpatente);
            this.Name = "EliminarPaciente";
            this.Text = "EliminarPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private TextBox txtPacienteAEliminar;
        private Label lblpatente;
    }
}