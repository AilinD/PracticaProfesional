namespace UI.Administrador
{
    partial class FormularioRestore
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
            this.btnRestore = new System.Windows.Forms.Button();
            this.progressBarRestore = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(133, 210);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // progressBarRestore
            // 
            this.progressBarRestore.Location = new System.Drawing.Point(30, 155);
            this.progressBarRestore.Name = "progressBarRestore";
            this.progressBarRestore.Size = new System.Drawing.Size(280, 23);
            this.progressBarRestore.TabIndex = 1;
            // 
            // FormularioRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 283);
            this.Controls.Add(this.progressBarRestore);
            this.Controls.Add(this.btnRestore);
            this.Name = "FormularioRestore";
            this.Text = "FormularioRestore";
            this.Load += new System.EventHandler(this.FormularioRestore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ProgressBar progressBarRestore;
    }
}