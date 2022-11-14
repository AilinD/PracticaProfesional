namespace SistemaMedico.Reportes
{
    partial class Reporte
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiosPorPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiosPorMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudiosToolStripMenuItem
            // 
            this.estudiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiosPorPacienteToolStripMenuItem,
            this.estudiosPorMedicoToolStripMenuItem});
            this.estudiosToolStripMenuItem.Name = "estudiosToolStripMenuItem";
            this.estudiosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.estudiosToolStripMenuItem.Text = "Estudios";
            // 
            // estudiosPorPacienteToolStripMenuItem
            // 
            this.estudiosPorPacienteToolStripMenuItem.Name = "estudiosPorPacienteToolStripMenuItem";
            this.estudiosPorPacienteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.estudiosPorPacienteToolStripMenuItem.Text = "Estudios Por Paciente";
            // 
            // estudiosPorMedicoToolStripMenuItem
            // 
            this.estudiosPorMedicoToolStripMenuItem.Name = "estudiosPorMedicoToolStripMenuItem";
            this.estudiosPorMedicoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.estudiosPorMedicoToolStripMenuItem.Text = "Estudios Por Medico";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem estudiosToolStripMenuItem;
        private ToolStripMenuItem estudiosPorPacienteToolStripMenuItem;
        private ToolStripMenuItem estudiosPorMedicoToolStripMenuItem;
    }
}