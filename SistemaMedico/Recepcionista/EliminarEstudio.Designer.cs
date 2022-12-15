namespace SistemaMedico.Recepcionista
{
    partial class EliminarEstudio
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
            this.txtEstudioaEliminar = new System.Windows.Forms.TextBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(389, 38);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "clik para buscar");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(232, 315);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 27);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "click para eliminar el estudio");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 201);
            this.dataGridView1.TabIndex = 27;
            // 
            // txtEstudioaEliminar
            // 
            this.txtEstudioaEliminar.Location = new System.Drawing.Point(187, 41);
            this.txtEstudioaEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstudioaEliminar.Name = "txtEstudioaEliminar";
            this.txtEstudioaEliminar.Size = new System.Drawing.Size(179, 23);
            this.txtEstudioaEliminar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtEstudioaEliminar, "Ingrese el Nombre del estudio");
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Location = new System.Drawing.Point(75, 44);
            this.lblEstudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(93, 15);
            this.lblEstudio.TabIndex = 25;
            this.lblEstudio.Text = "Nombre Estudio";
            // 
            // toolTip1
            // 
            this.toolTip1.UseFading = false;
            // 
            // EliminarEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 369);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEstudioaEliminar);
            this.Controls.Add(this.lblEstudio);
            this.Name = "EliminarEstudio";
            this.Text = "EliminarEstudio";
            this.Load += new System.EventHandler(this.EliminarEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private TextBox txtEstudioaEliminar;
        private Label lblEstudio;
        private ToolTip toolTip1;
    }
}