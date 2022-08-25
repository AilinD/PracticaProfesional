using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Administrador
{
    public partial class FormularioRestore : Form
    {
        public FormularioRestore()
        {
            InitializeComponent();
        }

        private void FormularioRestore_Load(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {

                ServiceLayer.BLL.RestoreService.Current.RestoreDatabase();
               // CaluculateAll(progressBar1);
                MessageBox.Show("Restore Exitoso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

    }
}
