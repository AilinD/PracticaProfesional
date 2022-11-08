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
        private string folder;
        private void FormularioRestore_Load(object sender, EventArgs e)
        {
            List<string> BDS = new List<string>();
            BDS.Add("SysCExpert");
            BDS.Add("PatenteFamilia");
            cboxRestore.DataSource = BDS;
            cboxRestore.DisplayMember = "Value";
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string db = cboxRestore.Text;
                string databaseName = string.Format(/*"{0}.bak"*/ db);
                string path = openFileDialog1.FileName;
                string save = folder;
                Services.DAL.RestoreRepository.Current.CrearRestore(databaseName,path,save);
                CaluculateAll(progressBarRestore);
                MessageBox.Show("Restore Exitoso!");
                this.Close();
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

        private void progressBarRestore_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
           
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

          
           
        }

        

       
    }
}
