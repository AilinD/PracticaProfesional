namespace UI.Administrador
{
    partial class ModificarPatentes
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
            this.txtNuevaPatente = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.lblNombrePat = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDescriptivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevaPatente
            // 
            this.txtNuevaPatente.Location = new System.Drawing.Point(485, 166);
            this.txtNuevaPatente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevaPatente.Name = "txtNuevaPatente";
            this.txtNuevaPatente.Size = new System.Drawing.Size(116, 23);
            this.txtNuevaPatente.TabIndex = 41;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(364, 170);
            this.lblNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(89, 15);
            this.lblNuevoNombre.TabIndex = 40;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(432, 249);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 27);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificarUS_Click);
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(132, 57);
            this.txtNombrePatente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(179, 23);
            this.txtNombrePatente.TabIndex = 37;
            // 
            // lblNombrePat
            // 
            this.lblNombrePat.AutoSize = true;
            this.lblNombrePat.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombrePat.Location = new System.Drawing.Point(28, 60);
            this.lblNombrePat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePat.Name = "lblNombrePat";
            this.lblNombrePat.Size = new System.Drawing.Size(94, 15);
            this.lblNombrePat.TabIndex = 36;
            this.lblNombrePat.Text = "Nombre Patente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(342, 53);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 173);
            this.dataGridView1.TabIndex = 34;
            // 
            // lblDescriptivo
            // 
            this.lblDescriptivo.Location = new System.Drawing.Point(461, 23);
            this.lblDescriptivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptivo.Name = "lblDescriptivo";
            this.lblDescriptivo.Size = new System.Drawing.Size(141, 85);
            this.lblDescriptivo.TabIndex = 39;
            this.lblDescriptivo.Text = "Si no indica el nombre de la patente por defecto traera todos los registros ";
            this.lblDescriptivo.Click += new System.EventHandler(this.label1_Click);
            // 
            // ModificarPatentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 362);
            this.Controls.Add(this.txtNuevaPatente);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.lblDescriptivo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombrePatente);
            this.Controls.Add(this.lblNombrePat);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ModificarPatentes";
            this.Text = "ModificarPatentes";
            this.Load += new System.EventHandler(this.ModificarPatentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNuevaPatente;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.Label lblNombrePat;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDescriptivo;
    }
}