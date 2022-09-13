namespace UI.Administrador
{
    partial class FormContBackRest
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
            this.btnOpcBackup = new System.Windows.Forms.Button();
            this.btnOpcRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpcBackup
            // 
            this.btnOpcBackup.Location = new System.Drawing.Point(75, 68);
            this.btnOpcBackup.Name = "btnOpcBackup";
            this.btnOpcBackup.Size = new System.Drawing.Size(75, 23);
            this.btnOpcBackup.TabIndex = 0;
            this.btnOpcBackup.Text = "Backup";
            this.btnOpcBackup.UseVisualStyleBackColor = true;
            this.btnOpcBackup.Click += new System.EventHandler(this.btnOpcBackup_Click);
            // 
            // btnOpcRestore
            // 
            this.btnOpcRestore.Location = new System.Drawing.Point(75, 135);
            this.btnOpcRestore.Name = "btnOpcRestore";
            this.btnOpcRestore.Size = new System.Drawing.Size(75, 23);
            this.btnOpcRestore.TabIndex = 1;
            this.btnOpcRestore.Text = "Restore";
            this.btnOpcRestore.UseVisualStyleBackColor = true;
            this.btnOpcRestore.Click += new System.EventHandler(this.btnOpcRestore_Click);
            // 
            // FormContBackRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 226);
            this.Controls.Add(this.btnOpcRestore);
            this.Controls.Add(this.btnOpcBackup);
            this.Name = "FormContBackRest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup & Restore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpcBackup;
        private System.Windows.Forms.Button btnOpcRestore;
    }
}