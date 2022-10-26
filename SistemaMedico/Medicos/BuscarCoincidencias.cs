using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Medicos
{
    public partial class BuscarCoincidencias : Form
    {
        public BuscarCoincidencias()
        {
            InitializeComponent();
        }

        private void BuscarCoincidencias_Load(object sender, EventArgs e)
        {
            try
            {
                Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\\Program Files (x86)\\swipl");
                Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
                string[] p = { "-q", "-f", @"BaseProlog.pl" };
                PlEngine.Initialize(p);
                PlEngine.PlCleanup();
            }
            catch (Exception ex)
            {

            }
           

        }                                           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            listBox1.Items.Clear();

            string[] p = { "-q", "-f", @"BaseProlog.pl" };
            PlEngine.Initialize(p);

            PlQuery cargar = new PlQuery("Cargar('BaseProlog.bd')");
            cargar.NextSolution();

            if (chkSintomaDe.Checked == true)
            {
                PlQuery consulta = new PlQuery("SintomaDe(S,"+texto+").");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                {
                    listBox1.Items.Add(z["S"].ToString());
                }
            }

            if (chkEspecialista.Checked == true)
            {
                PlQuery consulta = new PlQuery("EspecialistaDe(E," + texto + ").");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                {
                    listBox1.Items.Add(z["E"].ToString());
                }
            }
        }
    }
}
