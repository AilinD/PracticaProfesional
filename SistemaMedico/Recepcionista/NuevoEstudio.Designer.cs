namespace SistemaMedico.Recepcionista
{
    partial class NuevoEstudio
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
            this.txtNuevoestudio = new System.Windows.Forms.TextBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(136, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 27);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Insertar";
            this.toolTipHelp.SetToolTip(this.btnAgregar, "Click para insertar el nuevo Estudio");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNuevoestudio
            // 
            this.txtNuevoestudio.Location = new System.Drawing.Point(52, 79);
            this.txtNuevoestudio.Name = "txtNuevoestudio";
            this.txtNuevoestudio.Size = new System.Drawing.Size(262, 23);
            this.txtNuevoestudio.TabIndex = 1;
            this.toolTipHelp.SetToolTip(this.txtNuevoestudio, "Ingrese el nombre de el nuevo Estudio");
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Location = new System.Drawing.Point(95, 36);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(187, 15);
            this.lblEstudio.TabIndex = 2;
            this.lblEstudio.Text = "Ingrese nombre del nuevo estudio";
            // 
            // NuevoEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 222);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.txtNuevoestudio);
            this.Controls.Add(this.btnAgregar);
            this.Name = "NuevoEstudio";
            this.Text = "NuevoEstudio";
            this.Load += new System.EventHandler(this.NuevoEstudio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregar;
        private TextBox txtNuevoestudio;
        private Label lblEstudio;
        private ToolTip toolTipHelp;
    }
}