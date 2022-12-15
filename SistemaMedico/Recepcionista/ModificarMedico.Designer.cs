namespace SistemaMedico.Recepcionista
{
    partial class ModificarMedico
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
            this.txtNuevoContacto = new System.Windows.Forms.TextBox();
            this.lblNuevoContacto = new System.Windows.Forms.Label();
            this.txtNuevoDomicilio = new System.Windows.Forms.TextBox();
            this.lblNuevoDomicilio = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtApellidoMedico = new System.Windows.Forms.TextBox();
            this.lblApellidoMedico = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevoContacto
            // 
            this.txtNuevoContacto.Location = new System.Drawing.Point(145, 340);
            this.txtNuevoContacto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoContacto.Name = "txtNuevoContacto";
            this.txtNuevoContacto.Size = new System.Drawing.Size(170, 23);
            this.txtNuevoContacto.TabIndex = 52;
            this.toolTip1.SetToolTip(this.txtNuevoContacto, "Ingrese el nuevo contacto del Medico");
            // 
            // lblNuevoContacto
            // 
            this.lblNuevoContacto.AutoSize = true;
            this.lblNuevoContacto.Location = new System.Drawing.Point(32, 343);
            this.lblNuevoContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoContacto.Name = "lblNuevoContacto";
            this.lblNuevoContacto.Size = new System.Drawing.Size(94, 15);
            this.lblNuevoContacto.TabIndex = 51;
            this.lblNuevoContacto.Text = "Nuevo Contacto";
            // 
            // txtNuevoDomicilio
            // 
            this.txtNuevoDomicilio.Location = new System.Drawing.Point(145, 302);
            this.txtNuevoDomicilio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNuevoDomicilio.Name = "txtNuevoDomicilio";
            this.txtNuevoDomicilio.Size = new System.Drawing.Size(170, 23);
            this.txtNuevoDomicilio.TabIndex = 50;
            this.toolTip1.SetToolTip(this.txtNuevoDomicilio, "Ingrese el nuevo domicilio del Medico");
            // 
            // lblNuevoDomicilio
            // 
            this.lblNuevoDomicilio.AutoSize = true;
            this.lblNuevoDomicilio.Location = new System.Drawing.Point(32, 305);
            this.lblNuevoDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoDomicilio.Name = "lblNuevoDomicilio";
            this.lblNuevoDomicilio.Size = new System.Drawing.Size(96, 15);
            this.lblNuevoDomicilio.TabIndex = 49;
            this.lblNuevoDomicilio.Text = "Nuevo Domicilio";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(324, 336);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 27);
            this.btnModificar.TabIndex = 48;
            this.btnModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificar, "Seleccione para modificar los datos del medico");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificarMedico_Click);
            // 
            // txtApellidoMedico
            // 
            this.txtApellidoMedico.Location = new System.Drawing.Point(136, 24);
            this.txtApellidoMedico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellidoMedico.Name = "txtApellidoMedico";
            this.txtApellidoMedico.Size = new System.Drawing.Size(179, 23);
            this.txtApellidoMedico.TabIndex = 47;
            this.toolTip1.SetToolTip(this.txtApellidoMedico, "Ingrese el Apellido del Medico");
            // 
            // lblApellidoMedico
            // 
            this.lblApellidoMedico.AutoSize = true;
            this.lblApellidoMedico.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellidoMedico.Location = new System.Drawing.Point(32, 27);
            this.lblApellidoMedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoMedico.Name = "lblApellidoMedico";
            this.lblApellidoMedico.Size = new System.Drawing.Size(94, 15);
            this.lblApellidoMedico.TabIndex = 46;
            this.lblApellidoMedico.Text = "Apellido Medico";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(327, 21);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 27);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Seleccione para Buscar al medico");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscaMedico_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 216);
            this.dataGridView1.TabIndex = 44;
            // 
            // ModificarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 390);
            this.Controls.Add(this.txtNuevoContacto);
            this.Controls.Add(this.lblNuevoContacto);
            this.Controls.Add(this.txtNuevoDomicilio);
            this.Controls.Add(this.lblNuevoDomicilio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtApellidoMedico);
            this.Controls.Add(this.lblApellidoMedico);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificarMedico";
            this.Text = "ModificarMedico";
            this.Load += new System.EventHandler(this.ModificarMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNuevoContacto;
        private Label lblNuevoContacto;
        private TextBox txtNuevoDomicilio;
        private Label lblNuevoDomicilio;
        private Button btnModificar;
        private TextBox txtApellidoMedico;
        private Label lblApellidoMedico;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
    }
}