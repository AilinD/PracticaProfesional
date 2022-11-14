namespace SistemaMedico.Recepcionista
{
    partial class EliminarMedico
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
            this.txtMedicoAEliminar = new System.Windows.Forms.TextBox();
            this.lblApellidoMedico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(381, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(224, 304);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 201);
            this.dataGridView1.TabIndex = 17;
            // 
            // txtMedicoAEliminar
            // 
            this.txtMedicoAEliminar.Location = new System.Drawing.Point(171, 29);
            this.txtMedicoAEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMedicoAEliminar.Name = "txtMedicoAEliminar";
            this.txtMedicoAEliminar.Size = new System.Drawing.Size(179, 23);
            this.txtMedicoAEliminar.TabIndex = 16;
            // 
            // lblApellidoMedico
            // 
            this.lblApellidoMedico.AutoSize = true;
            this.lblApellidoMedico.Location = new System.Drawing.Point(67, 33);
            this.lblApellidoMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoMedico.Name = "lblApellidoMedico";
            this.lblApellidoMedico.Size = new System.Drawing.Size(94, 15);
            this.lblApellidoMedico.TabIndex = 15;
            this.lblApellidoMedico.Text = "Apellido Medico";
            // 
            // EliminarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 354);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMedicoAEliminar);
            this.Controls.Add(this.lblApellidoMedico);
            this.Name = "EliminarMedico";
            this.Text = "EliminarMedico";
            this.Load += new System.EventHandler(this.EliminarMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private TextBox txtMedicoAEliminar;
        private Label lblApellidoMedico;
    }
}