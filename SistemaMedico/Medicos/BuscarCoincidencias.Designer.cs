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
            this.chkSintomaDe = new System.Windows.Forms.CheckBox();
            this.chkEspecialista = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkSintomaDe
            // 
            this.chkSintomaDe.AutoSize = true;
            this.chkSintomaDe.Location = new System.Drawing.Point(51, 24);
            this.chkSintomaDe.Name = "chkSintomaDe";
            this.chkSintomaDe.Size = new System.Drawing.Size(87, 19);
            this.chkSintomaDe.TabIndex = 0;
            this.chkSintomaDe.Text = "Sintoma De";
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
            this.chkEspecialista.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(51, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(437, 199);
            this.listBox1.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(232, 328);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(413, 65);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BuscarCoincidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 363);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textBox1);
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
        private TextBox textBox1;
        private Button btnLimpiar;
    }
}