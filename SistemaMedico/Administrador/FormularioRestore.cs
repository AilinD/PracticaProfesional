using Services.BLL;
using SistemaMedico.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
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
            try
            {
                List<string> BDS = new List<string>();
                BDS.Add("SysCExpert");
                BDS.Add("PatenteFamilia");
                cboxRestore.DataSource = BDS;
                cboxRestore.DisplayMember = "Value";

                btnSeleccionar.Translate();
                btnGuardar.Translate();
                lblSeleccionar.Translate();
                lblSeleccBkp.Translate();
                tamanio();
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }
        private void tamanio()
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
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
                Limpiar();
                this.Close();
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void CaluculateAll(System.Windows.Forms.ProgressBar progressBar)
        {
            try
            {
                progressBar.Maximum = 100000;
                progressBar.Step = 1;

                for (int j = 0; j < 100000; j++)
                {
                    double pow = Math.Pow(j, j); //Calculation
                    progressBar.PerformStep();
                }
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void progressBarRestore_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }



        }

        private void Limpiar()
        {
            textBox1.Text = "";
        }

       
    }
}
