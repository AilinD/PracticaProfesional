namespace UI.Administrador
{
    partial class MenuPatenteFamilia
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
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPatentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(79, 40);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(75, 23);
            this.btnRoles.TabIndex = 0;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(79, 85);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnPatentes
            // 
            this.btnPatentes.Location = new System.Drawing.Point(79, 132);
            this.btnPatentes.Name = "btnPatentes";
            this.btnPatentes.Size = new System.Drawing.Size(75, 23);
            this.btnPatentes.TabIndex = 2;
            this.btnPatentes.Text = "Patentes";
            this.btnPatentes.UseVisualStyleBackColor = true;
            // 
            // MenuPatenteFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 212);
            this.Controls.Add(this.btnPatentes);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnRoles);
            this.Name = "MenuPatenteFamilia";
            this.Text = "MenuPatenteFamilia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPatentes;
    }
}