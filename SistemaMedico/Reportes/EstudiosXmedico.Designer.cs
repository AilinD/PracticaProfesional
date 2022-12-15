namespace SistemaMedico.Reportes
{
    partial class EstudiosXmedico
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatriculaM = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(289, 386);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.toolTip1.SetToolTip(this.btnGenerar, "Seleccione las filas desde el margen izquierdo y haga click aqui");
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(387, 270);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(115, 386);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "click para buscar al medico");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(55, 41);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(57, 15);
            this.lblMatricula.TabIndex = 10;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtMatriculaM
            // 
            this.txtMatriculaM.Location = new System.Drawing.Point(176, 38);
            this.txtMatriculaM.Name = "txtMatriculaM";
            this.txtMatriculaM.Size = new System.Drawing.Size(268, 23);
            this.txtMatriculaM.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtMatriculaM, "Ingrese la matrícula del médico");
            // 
            // EstudiosXmedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatriculaM);
            this.Name = "EstudiosXmedico";
            this.Text = "EstudiosXmedico";
            this.Load += new System.EventHandler(this.EstudiosXmedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerar;
        private DataGridView dataGridView1;
        private Button btnBuscar;
        private Label lblMatricula;
        private TextBox txtMatriculaM;
        private ToolTip toolTip1;
    }
}