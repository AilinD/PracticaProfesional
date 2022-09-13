using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Microsoft.SqlServer.Management.Smo;
using ServiceLayer.BLL;

namespace UI.Administrador
{
    public partial class FormularioBakup : Form
    {
        public FormularioBakup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {

                ServiceLayer.BLL.BackupService.Current.CrearBackup();
                CaluculateAll(progressBar1);
                MessageBox.Show("Backup Exitoso!");
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
               
                

           
        }

        private void FormularioBakup_Load(object sender, EventArgs e)
        {
           
        }
        private void CaluculateAll(System.Windows.Forms.ProgressBar progressBar)
        {
            progressBar.Maximum = 100000;
            progressBar.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j); //Calculation
                progressBar.PerformStep();
            }
        }


        private void lblPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //if (fbd.ShowDialog() == DialogResult.OK)
            //{
            //    txtubicacion.Text = fbd.SelectedPath;
            //    btnBackup.Enabled = true;
            //}
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
