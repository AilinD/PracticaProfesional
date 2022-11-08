using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico.Base_Experta
{
    public partial class IngresarSintoma : Form
    {
        public IngresarSintoma()
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\swipl");
            Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\swipl\bin");
            string[] p = { "-q", "-f", @"BaseProlog.pl" };
            PlEngine.Initialize(p);
            PlEngine.PlCleanup();

            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nuevosintoma = txtNuevoSintoma.Text;

        }

        private void IngresarSintoma_Load(object sender, EventArgs e)
        {
            try
            {
                string file = @"C:\\Programa\\PracticaProfesional\\SistemaMedico\\Recursos\\BaseProlog.pl";
                Load_file(file);
            }
            catch (PlException ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void Load_file(string s)
        {
            s = s.Replace("\\", "//");
            s = "consult('" + s + "')";
            string query = s.Replace("\\", "//");
            string[] p = { "-q", "-f", query };
            PlEngine.Initialize(p);
            try
            {
                PlQuery q = new PlQuery(s);
                q.NextSolution();
            }
            catch (SbsSW.SwiPlCs.Exceptions.PlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString(), "Error");
            }
        }
    }
}
