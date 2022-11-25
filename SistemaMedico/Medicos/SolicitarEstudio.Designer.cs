﻿namespace UI.Medicos
{
    partial class SolicitarEstudio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstudio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxEstudio = new System.Windows.Forms.ComboBox();
            this.lblSeleccionaEstudio = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.gridpaciente = new System.Windows.Forms.DataGridView();
            this.cbocestudio = new System.Windows.Forms.ComboBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridpaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 197);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(346, 31);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Location = new System.Drawing.Point(0, 0);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(100, 23);
            this.txtApellidoPaciente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btnEstudio
            // 
            this.btnEstudio.Location = new System.Drawing.Point(0, 0);
            this.btnEstudio.Name = "btnEstudio";
            this.btnEstudio.Size = new System.Drawing.Size(75, 23);
            this.btnEstudio.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // cboxEstudio
            // 
            this.cboxEstudio.Location = new System.Drawing.Point(0, 0);
            this.cboxEstudio.Name = "cboxEstudio";
            this.cboxEstudio.Size = new System.Drawing.Size(121, 23);
            this.cboxEstudio.TabIndex = 0;
            // 
            // lblSeleccionaEstudio
            // 
            this.lblSeleccionaEstudio.AutoSize = true;
            this.lblSeleccionaEstudio.Location = new System.Drawing.Point(548, 363);
            this.lblSeleccionaEstudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionaEstudio.Name = "lblSeleccionaEstudio";
            this.lblSeleccionaEstudio.Size = new System.Drawing.Size(105, 15);
            this.lblSeleccionaEstudio.TabIndex = 49;
            this.lblSeleccionaEstudio.Text = "Seleccione Estudio";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(548, 442);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 27);
            this.btnModificar.TabIndex = 48;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // txtDniPaciente
            // 
            this.txtDniPaciente.Location = new System.Drawing.Point(147, 32);
            this.txtDniPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.Size = new System.Drawing.Size(178, 23);
            this.txtDniPaciente.TabIndex = 47;
            this.txtDniPaciente.TextChanged += new System.EventHandler(this.txtApellidoaciente_TextChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.SystemColors.Control;
            this.lblDNI.Location = new System.Drawing.Point(29, 35);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(75, 15);
            this.lblDNI.TabIndex = 46;
            this.lblDNI.Text = "DNI Paciente";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(361, 32);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(87, 25);
            this.btnBusca.TabIndex = 45;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // gridpaciente
            // 
            this.gridpaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpaciente.Location = new System.Drawing.Point(32, 78);
            this.gridpaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridpaciente.Name = "gridpaciente";
            this.gridpaciente.Size = new System.Drawing.Size(416, 391);
            this.gridpaciente.TabIndex = 44;
            // 
            // cbocestudio
            // 
            this.cbocestudio.FormattingEnabled = true;
            this.cbocestudio.Location = new System.Drawing.Point(498, 393);
            this.cbocestudio.Name = "cbocestudio";
            this.cbocestudio.Size = new System.Drawing.Size(200, 23);
            this.cbocestudio.TabIndex = 50;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(498, 78);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(200, 263);
            this.txtComentarios.TabIndex = 55;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(548, 40);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(75, 15);
            this.lblComentarios.TabIndex = 56;
            this.lblComentarios.Text = "Comentarios";
            // 
            // SolicitarEstudio
            // 
            this.ClientSize = new System.Drawing.Size(739, 490);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.cbocestudio);
            this.Controls.Add(this.lblSeleccionaEstudio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDniPaciente);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.gridpaciente);
            this.Name = "SolicitarEstudio";
            this.Text = "SolicitaEstudioPaciente";
            this.Load += new System.EventHandler(this.SolicitarEstudio_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridpaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBuscar;
        private TextBox txtApellidoPaciente;
        private Label label1;
        private Button btnEstudio;
        private Label label2;
        private ComboBox cboxEstudio;
        private Label lblSeleccionaEstudio;
        private Button btnModificar;
        private TextBox txtDniPaciente;
        private Label lblDNI;
        private Button btnBusca;
        private DataGridView gridpaciente;
        private ComboBox cbocestudio;
        private TextBox txtComentarios;
        private Label lblComentarios;
    }
}