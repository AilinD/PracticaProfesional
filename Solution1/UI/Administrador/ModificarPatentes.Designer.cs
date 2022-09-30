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
            this.btnModificarUS = new System.Windows.Forms.Button();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevaPatente
            // 
            this.txtNuevaPatente.Location = new System.Drawing.Point(416, 144);
            this.txtNuevaPatente.Name = "txtNuevaPatente";
            this.txtNuevaPatente.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaPatente.TabIndex = 41;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(312, 147);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(79, 13);
            this.lblNuevoNombre.TabIndex = 40;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // btnModificarUS
            // 
            this.btnModificarUS.Location = new System.Drawing.Point(370, 216);
            this.btnModificarUS.Name = "btnModificarUS";
            this.btnModificarUS.Size = new System.Drawing.Size(75, 23);
            this.btnModificarUS.TabIndex = 38;
            this.btnModificarUS.Text = "Modificar";
            this.btnModificarUS.UseVisualStyleBackColor = true;
            this.btnModificarUS.Click += new System.EventHandler(this.btnModificarUS_Click);
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(113, 49);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(154, 20);
            this.txtNombrePatente.TabIndex = 37;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(24, 52);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 13);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Nombre Patente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(395, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 74);
            this.label1.TabIndex = 39;
            this.label1.Text = "Si no indica el nombre de la patente por defecto traera todos los registros ";
            // 
            // ModificarPatentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 314);
            this.Controls.Add(this.txtNuevaPatente);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificarUS);
            this.Controls.Add(this.txtNombrePatente);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificarPatentes";
            this.Text = "ModificarPatentes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNuevaPatente;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.Button btnModificarUS;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}