namespace UI.Recepcionista
{
    partial class NuevaObraSocial
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
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNuevaOS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(30, 64);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(114, 15);
            this.lblObraSocial.TabIndex = 0;
            this.lblObraSocial.Text = "Nombre Obra Social";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(125, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 26);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNuevaOS
            // 
            this.txtNuevaOS.Location = new System.Drawing.Point(165, 61);
            this.txtNuevaOS.Name = "txtNuevaOS";
            this.txtNuevaOS.Size = new System.Drawing.Size(144, 23);
            this.txtNuevaOS.TabIndex = 2;
            // 
            // NuevaObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 230);
            this.Controls.Add(this.txtNuevaOS);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblObraSocial);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NuevaObraSocial";
            this.Text = "Nueva Obra Social";
            this.Load += new System.EventHandler(this.NuevaObraSocial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblObraSocial;
        private Button btnAgregar;
        private TextBox txtNuevaOS;
    }
}