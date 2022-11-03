namespace SistemaMedico.Recepcionista
{
    partial class ModificarObraSocial
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
            this.btnModificarMedico = new System.Windows.Forms.Button();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscaOS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(513, 79);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(183, 23);
            this.txtNuevoNombre.TabIndex = 59;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(416, 82);
            this.lblNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(89, 15);
            this.lblNuevoNombre.TabIndex = 58;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // btnModificarMedico
            // 
            this.btnModificarMedico.Location = new System.Drawing.Point(490, 138);
            this.btnModificarMedico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarMedico.Name = "btnModificarMedico";
            this.btnModificarMedico.Size = new System.Drawing.Size(88, 27);
            this.btnModificarMedico.TabIndex = 57;
            this.btnModificarMedico.Text = "Modificar";
            this.btnModificarMedico.UseVisualStyleBackColor = true;
            this.btnModificarMedico.Click += new System.EventHandler(this.btnModificarMedico_Click);
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Location = new System.Drawing.Point(97, 24);
            this.txtObraSocial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(179, 23);
            this.txtObraSocial.TabIndex = 56;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(13, 27);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 15);
            this.lblUsuario.TabIndex = 55;
            this.lblUsuario.Text = "Obra Social";
            // 
            // btnBuscaOS
            // 
            this.btnBuscaOS.Location = new System.Drawing.Point(305, 21);
            this.btnBuscaOS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscaOS.Name = "btnBuscaOS";
            this.btnBuscaOS.Size = new System.Drawing.Size(88, 27);
            this.btnBuscaOS.TabIndex = 54;
            this.btnBuscaOS.Text = "Buscar";
            this.btnBuscaOS.UseVisualStyleBackColor = true;
            this.btnBuscaOS.Click += new System.EventHandler(this.btnBuscaMedico_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 216);
            this.dataGridView1.TabIndex = 53;
            // 
            // ModificarObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 323);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.btnModificarMedico);
            this.Controls.Add(this.txtObraSocial);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscaOS);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificarObraSocial";
            this.Text = "ModificarObraSocial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtNuevoNombre;
        private Label lblNuevoNombre;
        private Button btnModificarMedico;
        private TextBox txtObraSocial;
        private Label lblUsuario;
        private Button btnBuscaOS;
        private DataGridView dataGridView1;
    }
}