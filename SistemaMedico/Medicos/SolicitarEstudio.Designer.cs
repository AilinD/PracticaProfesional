namespace UI.Medicos
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
            this.lblNuevoDomicilio = new System.Windows.Forms.Label();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.txtApellidoaciente = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscaPaciente = new System.Windows.Forms.Button();
            this.gridpaciente = new System.Windows.Forms.DataGridView();
            this.cbocestudio = new System.Windows.Forms.ComboBox();
            this.txtApellidoMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscaMedico = new System.Windows.Forms.Button();
            this.gridmedico = new System.Windows.Forms.DataGridView();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridpaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmedico)).BeginInit();
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
            // lblNuevoDomicilio
            // 
            this.lblNuevoDomicilio.AutoSize = true;
            this.lblNuevoDomicilio.Location = new System.Drawing.Point(548, 363);
            this.lblNuevoDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoDomicilio.Name = "lblNuevoDomicilio";
            this.lblNuevoDomicilio.Size = new System.Drawing.Size(105, 15);
            this.lblNuevoDomicilio.TabIndex = 49;
            this.lblNuevoDomicilio.Text = "Seleccione Estudio";
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.Location = new System.Drawing.Point(548, 442);
            this.btnModificarPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(105, 27);
            this.btnModificarPaciente.TabIndex = 48;
            this.btnModificarPaciente.Text = "Modificar";
            this.btnModificarPaciente.UseVisualStyleBackColor = true;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // txtApellidoaciente
            // 
            this.txtApellidoaciente.Location = new System.Drawing.Point(141, 32);
            this.txtApellidoaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoaciente.Name = "txtApellidoaciente";
            this.txtApellidoaciente.Size = new System.Drawing.Size(178, 23);
            this.txtApellidoaciente.TabIndex = 47;
            this.txtApellidoaciente.TextChanged += new System.EventHandler(this.txtApellidoaciente_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(23, 35);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 15);
            this.lblUsuario.TabIndex = 46;
            this.lblUsuario.Text = "Apellido Paciente";
            // 
            // btnBuscaPaciente
            // 
            this.btnBuscaPaciente.Location = new System.Drawing.Point(355, 32);
            this.btnBuscaPaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaPaciente.Name = "btnBuscaPaciente";
            this.btnBuscaPaciente.Size = new System.Drawing.Size(87, 25);
            this.btnBuscaPaciente.TabIndex = 45;
            this.btnBuscaPaciente.Text = "Buscar";
            this.btnBuscaPaciente.UseVisualStyleBackColor = true;
            this.btnBuscaPaciente.Click += new System.EventHandler(this.btnBuscaPaciente_Click);
            // 
            // gridpaciente
            // 
            this.gridpaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpaciente.Location = new System.Drawing.Point(26, 78);
            this.gridpaciente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridpaciente.Name = "gridpaciente";
            this.gridpaciente.Size = new System.Drawing.Size(416, 147);
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
            // txtApellidoMedico
            // 
            this.txtApellidoMedico.Location = new System.Drawing.Point(141, 270);
            this.txtApellidoMedico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoMedico.Name = "txtApellidoMedico";
            this.txtApellidoMedico.Size = new System.Drawing.Size(179, 23);
            this.txtApellidoMedico.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(23, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Apellido Medico";
            // 
            // btnBuscaMedico
            // 
            this.btnBuscaMedico.Location = new System.Drawing.Point(355, 270);
            this.btnBuscaMedico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaMedico.Name = "btnBuscaMedico";
            this.btnBuscaMedico.Size = new System.Drawing.Size(88, 27);
            this.btnBuscaMedico.TabIndex = 52;
            this.btnBuscaMedico.Text = "Buscar";
            this.btnBuscaMedico.UseVisualStyleBackColor = true;
            this.btnBuscaMedico.Click += new System.EventHandler(this.btnBuscaMedico_Click);
            // 
            // gridmedico
            // 
            this.gridmedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmedico.Location = new System.Drawing.Point(26, 316);
            this.gridmedico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridmedico.Name = "gridmedico";
            this.gridmedico.Size = new System.Drawing.Size(416, 153);
            this.gridmedico.TabIndex = 51;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(498, 78);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(200, 263);
            this.txtComentarios.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Comentarios";
            // 
            // SolicitarEstudio
            // 
            this.ClientSize = new System.Drawing.Size(739, 490);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.txtApellidoMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscaMedico);
            this.Controls.Add(this.gridmedico);
            this.Controls.Add(this.cbocestudio);
            this.Controls.Add(this.lblNuevoDomicilio);
            this.Controls.Add(this.btnModificarPaciente);
            this.Controls.Add(this.txtApellidoaciente);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscaPaciente);
            this.Controls.Add(this.gridpaciente);
            this.Name = "SolicitarEstudio";
            this.Text = "SolicitaEstudioPaciente";
            this.Load += new System.EventHandler(this.SolicitarEstudio_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridpaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmedico)).EndInit();
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
        private Label lblNuevoDomicilio;
        private Button btnModificarPaciente;
        private TextBox txtApellidoaciente;
        private Label lblUsuario;
        private Button btnBuscaPaciente;
        private DataGridView gridpaciente;
        private ComboBox cbocestudio;
        private TextBox txtApellidoMedico;
        private Label label3;
        private Button btnBuscaMedico;
        private DataGridView gridmedico;
        private TextBox txtComentarios;
        private Label label4;
    }
}