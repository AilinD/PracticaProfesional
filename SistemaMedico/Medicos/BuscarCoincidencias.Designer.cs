namespace UI.Medicos
{
    partial class BuscarCoincidencias
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
            this.chkSintomaDe = new System.Windows.Forms.CheckBox();
            this.chkEspecialista = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtxEspecialista = new System.Windows.Forms.TextBox();
            this.chkenf = new System.Windows.Forms.CheckBox();
            this.txtenfermedad = new System.Windows.Forms.TextBox();
            this.chkEspecialidades = new System.Windows.Forms.CheckBox();
            this.txtespecialidades = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // chkSintomaDe
            // 
            this.chkSintomaDe.AutoSize = true;
            this.chkSintomaDe.Location = new System.Drawing.Point(51, 24);
            this.chkSintomaDe.Name = "chkSintomaDe";
            this.chkSintomaDe.Size = new System.Drawing.Size(70, 19);
            this.chkSintomaDe.TabIndex = 0;
            this.chkSintomaDe.Text = "Sintoma";
            this.chkSintomaDe.UseVisualStyleBackColor = true;
            // 
            // chkEspecialista
            // 
            this.chkEspecialista.AutoSize = true;
            this.chkEspecialista.Location = new System.Drawing.Point(176, 24);
            this.chkEspecialista.Name = "chkEspecialista";
            this.chkEspecialista.Size = new System.Drawing.Size(103, 19);
            this.chkEspecialista.TabIndex = 1;
            this.chkEspecialista.Text = "Especialista De";
            this.toolTip1.SetToolTip(this.chkEspecialista, "Tilde el cuadro de arriba y escriba el nombre de la enfermedad");
            this.chkEspecialista.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(51, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(503, 199);
            this.listBox1.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(176, 328);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsultar, "click para consultar la base experta");
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(51, 65);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(101, 23);
            this.txtSintomas.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtSintomas, "Tilde el cuadro de arriba y escriba el nombre del sintoma");
            this.txtSintomas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(425, 328);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiar, "click para limpair el cuadro de resultados");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtxEspecialista
            // 
            this.txtxEspecialista.Location = new System.Drawing.Point(189, 65);
            this.txtxEspecialista.Name = "txtxEspecialista";
            this.txtxEspecialista.Size = new System.Drawing.Size(101, 23);
            this.txtxEspecialista.TabIndex = 7;
            // 
            // chkenf
            // 
            this.chkenf.AutoSize = true;
            this.chkenf.Location = new System.Drawing.Point(321, 24);
            this.chkenf.Name = "chkenf";
            this.chkenf.Size = new System.Drawing.Size(92, 19);
            this.chkenf.TabIndex = 8;
            this.chkenf.Text = "Sintomas De";
            this.toolTip1.SetToolTip(this.chkenf, "Tilde el cuadro de arriba y escriba el nombre de la enfermedad");
            this.chkenf.UseVisualStyleBackColor = true;
            // 
            // txtenfermedad
            // 
            this.txtenfermedad.Location = new System.Drawing.Point(321, 66);
            this.txtenfermedad.Name = "txtenfermedad";
            this.txtenfermedad.Size = new System.Drawing.Size(101, 23);
            this.txtenfermedad.TabIndex = 9;
            // 
            // chkEspecialidades
            // 
            this.chkEspecialidades.AutoSize = true;
            this.chkEspecialidades.Location = new System.Drawing.Point(451, 24);
            this.chkEspecialidades.Name = "chkEspecialidades";
            this.chkEspecialidades.Size = new System.Drawing.Size(119, 19);
            this.chkEspecialidades.TabIndex = 10;
            this.chkEspecialidades.Text = "Especialidades De";
            this.toolTip1.SetToolTip(this.chkEspecialidades, "Tilde el cuadro de arriba y escriba el nombre del especialista");
            this.chkEspecialidades.UseVisualStyleBackColor = true;
            // 
            // txtespecialidades
            // 
            this.txtespecialidades.Location = new System.Drawing.Point(453, 65);
            this.txtespecialidades.Name = "txtespecialidades";
            this.txtespecialidades.Size = new System.Drawing.Size(101, 23);
            this.txtespecialidades.TabIndex = 11;
            // 
            // BuscarCoincidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 363);
            this.Controls.Add(this.txtespecialidades);
            this.Controls.Add(this.chkEspecialidades);
            this.Controls.Add(this.txtenfermedad);
            this.Controls.Add(this.chkenf);
            this.Controls.Add(this.txtxEspecialista);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chkEspecialista);
            this.Controls.Add(this.chkSintomaDe);
            this.Name = "BuscarCoincidencias";
            this.Text = "BuscarCoincidencias";
            this.Load += new System.EventHandler(this.BuscarCoincidencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkSintomaDe;
        private CheckBox chkEspecialista;
        private ListBox listBox1;
        private Button btnConsultar;
        private TextBox txtSintomas;
        private Button btnLimpiar;
        private TextBox txtxEspecialista;
        private CheckBox chkenf;
        private TextBox txtenfermedad;
        private CheckBox chkEspecialidades;
        private TextBox txtespecialidades;
        private ToolTip toolTip1;
    }
}