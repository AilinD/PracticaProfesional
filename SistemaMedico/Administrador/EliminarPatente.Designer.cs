namespace UI.Administrador
{
    partial class EliminarPatente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPatenteAEliminar = new System.Windows.Forms.TextBox();
            this.lblpatente = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(338, 21);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Click para buscar la patente");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(181, 298);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "Seleccionar la fila de la patente desde el margen superior izquierdo de la tabla " +
        "y click aca");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 201);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtPatenteAEliminar
            // 
            this.txtPatenteAEliminar.Location = new System.Drawing.Point(128, 23);
            this.txtPatenteAEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPatenteAEliminar.Name = "txtPatenteAEliminar";
            this.txtPatenteAEliminar.Size = new System.Drawing.Size(179, 23);
            this.txtPatenteAEliminar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtPatenteAEliminar, "Ingrese el nombre de la patente a eliminar");
            // 
            // lblpatente
            // 
            this.lblpatente.AutoSize = true;
            this.lblpatente.Location = new System.Drawing.Point(24, 27);
            this.lblpatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpatente.Name = "lblpatente";
            this.lblpatente.Size = new System.Drawing.Size(94, 15);
            this.lblpatente.TabIndex = 5;
            this.lblpatente.Text = "Nombre Patente";
            // 
            // EliminarPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 352);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPatenteAEliminar);
            this.Controls.Add(this.lblpatente);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EliminarPatente";
            this.Text = "EliminarPatente";
            this.Load += new System.EventHandler(this.EliminarPatente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPatenteAEliminar;
        private System.Windows.Forms.Label lblpatente;
        private ToolTip toolTip1;
    }
}