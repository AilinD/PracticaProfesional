﻿namespace SistemaMedico.Medicos
{
    partial class Diagnostico
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
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridpaciente = new System.Windows.Forms.DataGridView();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridpaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Location = new System.Drawing.Point(158, 33);
            this.txtApellidoPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(189, 23);
            this.txtApellidoPaciente.TabIndex = 51;
            this.toolTip1.SetToolTip(this.txtApellidoPaciente, "Ingrese el Apellido del Paciente");
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(39, 36);
            this.lblApellidoPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(99, 15);
            this.lblApellidoPaciente.TabIndex = 50;
            this.lblApellidoPaciente.Text = "Apellido Paciente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(371, 33);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 25);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "click para buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridpaciente
            // 
            this.gridpaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpaciente.Location = new System.Drawing.Point(42, 79);
            this.gridpaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridpaciente.Name = "gridpaciente";
            this.gridpaciente.Size = new System.Drawing.Size(416, 147);
            this.gridpaciente.TabIndex = 48;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(42, 250);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(70, 15);
            this.lblDiagnostico.TabIndex = 58;
            this.lblDiagnostico.Text = "Diagnostico";
            this.lblDiagnostico.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(39, 280);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(416, 148);
            this.txtComentarios.TabIndex = 57;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(198, 446);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Seleccione la fila de los resultados de la tabla en el margen izquierdo y haga cl" +
        "ick aqui");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 493);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.txtApellidoPaciente);
            this.Controls.Add(this.lblApellidoPaciente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gridpaciente);
            this.Name = "Diagnostico";
            this.Text = "Diagnostico";
            this.Load += new System.EventHandler(this.Diagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridpaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtApellidoPaciente;
        private Label lblApellidoPaciente;
        private Button btnBuscar;
        private DataGridView gridpaciente;
        private Label lblDiagnostico;
        private TextBox txtComentarios;
        private Button btnGuardar;
        private ToolTip toolTip1;
    }
}