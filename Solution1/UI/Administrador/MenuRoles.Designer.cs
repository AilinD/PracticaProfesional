namespace UI.Administrador
{
    partial class MenuRoles
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
            this.btnEjec = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.chkModificar = new System.Windows.Forms.CheckBox();
            this.btnNuevoRol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEjec
            // 
            this.btnEjec.Location = new System.Drawing.Point(294, 182);
            this.btnEjec.Name = "btnEjec";
            this.btnEjec.Size = new System.Drawing.Size(75, 23);
            this.btnEjec.TabIndex = 19;
            this.btnEjec.Text = "Ejecutar";
            this.btnEjec.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(330, 29);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(82, 23);
            this.btnAll.TabIndex = 18;
            this.btnAll.Text = "BuscarTodos";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(294, 136);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkEliminar.TabIndex = 17;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkModificar
            // 
            this.chkModificar.AutoSize = true;
            this.chkModificar.Location = new System.Drawing.Point(294, 112);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(69, 17);
            this.chkModificar.TabIndex = 16;
            this.chkModificar.Text = "Modificar";
            this.chkModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoRol
            // 
            this.btnNuevoRol.Location = new System.Drawing.Point(22, 247);
            this.btnNuevoRol.Name = "btnNuevoRol";
            this.btnNuevoRol.Size = new System.Drawing.Size(103, 23);
            this.btnNuevoRol.TabIndex = 15;
            this.btnNuevoRol.Text = "Nuevo Rol";
            this.btnNuevoRol.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Acciones";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.SystemColors.Control;
            this.lblRol.Location = new System.Drawing.Point(19, 34);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 13);
            this.lblRol.TabIndex = 12;
            this.lblRol.Text = "IdRol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // MenuRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 297);
            this.Controls.Add(this.btnEjec);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.chkModificar);
            this.Controls.Add(this.btnNuevoRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MenuRoles";
            this.Text = "MenuRoles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjec;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.CheckBox chkModificar;
        private System.Windows.Forms.Button btnNuevoRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}