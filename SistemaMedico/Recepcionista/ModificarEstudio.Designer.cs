namespace SistemaMedico.Recepcionista
{
    partial class ModificarEstudio
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
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.btnModificarEstudio = new System.Windows.Forms.Button();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.lblestudio = new System.Windows.Forms.Label();
            this.btnBuscaEstudio = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(555, 80);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(183, 23);
            this.txtNuevoNombre.TabIndex = 66;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(442, 83);
            this.lblNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(89, 15);
            this.lblNuevoNombre.TabIndex = 65;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // btnModificarEstudio
            // 
            this.btnModificarEstudio.Location = new System.Drawing.Point(532, 139);
            this.btnModificarEstudio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarEstudio.Name = "btnModificarEstudio";
            this.btnModificarEstudio.Size = new System.Drawing.Size(88, 27);
            this.btnModificarEstudio.TabIndex = 64;
            this.btnModificarEstudio.Text = "Modificar";
            this.btnModificarEstudio.UseVisualStyleBackColor = true;
            this.btnModificarEstudio.Click += new System.EventHandler(this.btnModificarEstudio_Click);
            // 
            // txtEstudio
            // 
            this.txtEstudio.Location = new System.Drawing.Point(144, 25);
            this.txtEstudio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(179, 23);
            this.txtEstudio.TabIndex = 63;
            // 
            // lblestudio
            // 
            this.lblestudio.AutoSize = true;
            this.lblestudio.BackColor = System.Drawing.SystemColors.Control;
            this.lblestudio.Location = new System.Drawing.Point(37, 28);
            this.lblestudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestudio.Name = "lblestudio";
            this.lblestudio.Size = new System.Drawing.Size(93, 15);
            this.lblestudio.TabIndex = 62;
            this.lblestudio.Text = "Nombre Estudio";
            // 
            // btnBuscaEstudio
            // 
            this.btnBuscaEstudio.Location = new System.Drawing.Point(343, 21);
            this.btnBuscaEstudio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaEstudio.Name = "btnBuscaEstudio";
            this.btnBuscaEstudio.Size = new System.Drawing.Size(88, 27);
            this.btnBuscaEstudio.TabIndex = 61;
            this.btnBuscaEstudio.Text = "Buscar";
            this.btnBuscaEstudio.UseVisualStyleBackColor = true;
            this.btnBuscaEstudio.Click += new System.EventHandler(this.btnBuscaEstudio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 216);
            this.dataGridView1.TabIndex = 60;
            // 
            // ModificarEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 354);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.btnModificarEstudio);
            this.Controls.Add(this.txtEstudio);
            this.Controls.Add(this.lblestudio);
            this.Controls.Add(this.btnBuscaEstudio);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificarEstudio";
            this.Text = "ModificarEstudio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNuevoNombre;
        private Label lblNuevoNombre;
        private Button btnModificarEstudio;
        private TextBox txtEstudio;
        private Label lblestudio;
        private Button btnBuscaEstudio;
        private DataGridView dataGridView1;
    }
}