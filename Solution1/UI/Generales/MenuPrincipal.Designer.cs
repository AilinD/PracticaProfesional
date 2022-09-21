namespace UI.Generales
{
    partial class MenuPrincipal
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
            this.btnMenuRecepcion = new System.Windows.Forms.Button();
            this.btnMenuMedic = new System.Windows.Forms.Button();
            this.btnMenuExperto = new System.Windows.Forms.Button();
            this.btnMenuAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuRecepcion
            // 
            this.btnMenuRecepcion.Location = new System.Drawing.Point(66, 53);
            this.btnMenuRecepcion.Name = "btnMenuRecepcion";
            this.btnMenuRecepcion.Size = new System.Drawing.Size(109, 23);
            this.btnMenuRecepcion.TabIndex = 0;
            this.btnMenuRecepcion.Text = "Menu Recepcion";
            this.btnMenuRecepcion.UseVisualStyleBackColor = true;
            this.btnMenuRecepcion.Click += new System.EventHandler(this.btnMenuRecepcion_Click);
            // 
            // btnMenuMedic
            // 
            this.btnMenuMedic.Location = new System.Drawing.Point(76, 94);
            this.btnMenuMedic.Name = "btnMenuMedic";
            this.btnMenuMedic.Size = new System.Drawing.Size(89, 23);
            this.btnMenuMedic.TabIndex = 1;
            this.btnMenuMedic.Text = "Menu Medicos";
            this.btnMenuMedic.UseVisualStyleBackColor = true;
            // 
            // btnMenuExperto
            // 
            this.btnMenuExperto.Location = new System.Drawing.Point(66, 139);
            this.btnMenuExperto.Name = "btnMenuExperto";
            this.btnMenuExperto.Size = new System.Drawing.Size(109, 23);
            this.btnMenuExperto.TabIndex = 2;
            this.btnMenuExperto.Text = "Menu Base Experta";
            this.btnMenuExperto.UseVisualStyleBackColor = true;
            // 
            // btnMenuAdm
            // 
            this.btnMenuAdm.Location = new System.Drawing.Point(66, 183);
            this.btnMenuAdm.Name = "btnMenuAdm";
            this.btnMenuAdm.Size = new System.Drawing.Size(109, 23);
            this.btnMenuAdm.TabIndex = 3;
            this.btnMenuAdm.Text = "Menu Administrador";
            this.btnMenuAdm.UseVisualStyleBackColor = true;
            this.btnMenuAdm.Click += new System.EventHandler(this.btnMenuAdm_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 248);
            this.Controls.Add(this.btnMenuAdm);
            this.Controls.Add(this.btnMenuExperto);
            this.Controls.Add(this.btnMenuMedic);
            this.Controls.Add(this.btnMenuRecepcion);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuRecepcion;
        private System.Windows.Forms.Button btnMenuMedic;
        private System.Windows.Forms.Button btnMenuExperto;
        private System.Windows.Forms.Button btnMenuAdm;
    }
}