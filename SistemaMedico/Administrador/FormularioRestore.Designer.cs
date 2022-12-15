namespace UI.Administrador
{
    partial class FormularioRestore
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.progressBarRestore = new System.Windows.Forms.ProgressBar();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblSeleccBkp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboxRestore = new System.Windows.Forms.ComboBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(221, 269);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 27);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Click para guardar el backup de la base");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // progressBarRestore
            // 
            this.progressBarRestore.Location = new System.Drawing.Point(71, 189);
            this.progressBarRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBarRestore.Name = "progressBarRestore";
            this.progressBarRestore.Size = new System.Drawing.Size(397, 27);
            this.progressBarRestore.TabIndex = 1;
            this.progressBarRestore.Click += new System.EventHandler(this.progressBarRestore_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(416, 52);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(88, 27);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblSeleccBkp
            // 
            this.lblSeleccBkp.AutoSize = true;
            this.lblSeleccBkp.Location = new System.Drawing.Point(43, 58);
            this.lblSeleccBkp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccBkp.Name = "lblSeleccBkp";
            this.lblSeleccBkp.Size = new System.Drawing.Size(115, 15);
            this.lblSeleccBkp.TabIndex = 3;
            this.lblSeleccBkp.Text = "Seleccionar backup :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 23);
            this.textBox1.TabIndex = 4;
            // 
            // cboxRestore
            // 
            this.cboxRestore.FormattingEnabled = true;
            this.cboxRestore.Location = new System.Drawing.Point(166, 119);
            this.cboxRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxRestore.Name = "cboxRestore";
            this.cboxRestore.Size = new System.Drawing.Size(338, 23);
            this.cboxRestore.TabIndex = 11;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(44, 119);
            this.lblSeleccionar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(111, 15);
            this.lblSeleccionar.TabIndex = 10;
            this.lblSeleccionar.Text = "Seleccione la base : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos BAK (*.bak)|*.bak";
            // 
            // FormularioRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 353);
            this.Controls.Add(this.cboxRestore);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSeleccBkp);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.progressBarRestore);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormularioRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Restore";
            this.Load += new System.EventHandler(this.FormularioRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ProgressBar progressBarRestore;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblSeleccBkp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboxRestore;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
    }
}