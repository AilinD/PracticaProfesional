namespace SistemaMedico.Recepcionista
{
    partial class NuevoMedico
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.cboxEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(322, 206);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 27);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Generar";
            this.toolTipAyuda.SetToolTip(this.btnAgregar, "Click para guardar el Medico");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(13, 141);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(57, 15);
            this.lblMatricula.TabIndex = 30;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(507, 92);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(191, 23);
            this.txtContacto.TabIndex = 26;
            this.toolTipAyuda.SetToolTip(this.txtContacto, "Ingrese el numero de contacto del Medico");
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(369, 95);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(56, 15);
            this.lblContacto.TabIndex = 25;
            this.lblContacto.Text = "Contacto";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(508, 44);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(191, 23);
            this.txtDomicilio.TabIndex = 24;
            this.toolTipAyuda.SetToolTip(this.txtDomicilio, "Ingrese el Domicilio del Medico");
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(370, 50);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(58, 15);
            this.lblDomicilio.TabIndex = 23;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 23);
            this.txtNombre.TabIndex = 22;
            this.toolTipAyuda.SetToolTip(this.txtNombre, "Ingrese el Nombre del Medico");
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 92);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 44);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(191, 23);
            this.txtApellido.TabIndex = 20;
            this.toolTipAyuda.SetToolTip(this.txtApellido, "Ingrese el Apellido del Medico");
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 47);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(151, 144);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(191, 23);
            this.txtMatricula.TabIndex = 36;
            this.toolTipAyuda.SetToolTip(this.txtMatricula, "Ingrese el numero de Matricula del Medico");
            // 
            // cboxEspecialidad
            // 
            this.cboxEspecialidad.FormattingEnabled = true;
            this.cboxEspecialidad.Location = new System.Drawing.Point(508, 147);
            this.cboxEspecialidad.Name = "cboxEspecialidad";
            this.cboxEspecialidad.Size = new System.Drawing.Size(190, 23);
            this.cboxEspecialidad.TabIndex = 37;
            this.toolTipAyuda.SetToolTip(this.cboxEspecialidad, "Seleccione la especialidad del Médico");
            this.cboxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cboxEspecialidad_SelectedIndexChanged);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(370, 147);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(72, 15);
            this.lblEspecialidad.TabIndex = 38;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // NuevoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 265);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cboxEspecialidad);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Name = "NuevoMedico";
            this.Text = "NuevoMedico";
            this.Load += new System.EventHandler(this.NuevoMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAgregar;
        private Label lblMatricula;
        private TextBox txtContacto;
        private Label lblContacto;
        private TextBox txtDomicilio;
        private Label lblDomicilio;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtMatricula;
        private ComboBox cboxEspecialidad;
        private Label lblEspecialidad;
        private ToolTip toolTipAyuda;
    }
}