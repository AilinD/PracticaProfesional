//using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI.Medicos
{
    public partial class BuscarCoincidencias : Form
    {
        public BuscarCoincidencias()
        {
            InitializeComponent();

            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\\Program Files (x86)\\swipl");
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            string[] p = { "-q", "-f", @"BaseProlog.pl" };
            PlEngine.Initialize(p);
            PlEngine.PlCleanup();





        }

        private void BuscarCoincidencias_Load(object sender, EventArgs e)
        {
            try
            {
                string file = @"C:\\Programa\\PracticaProfesional\\SistemaMedico\\Recursos\\BaseProlog.pl";
            Load_file(file);
            }
            catch (PlException  ex)
            {
                Console.WriteLine(ex);
            }
           

        }                                           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string[] p = { "-q", "-f", @"BaseProlog.pl" };
                 
            if (chkSintomaDe.Checked == true)
            {
                string query = $"sintomade({textBox1.Text},X)";

                PlQuery consulta = new PlQuery(query);
                consulta.NextSolution();

                foreach (PlQueryVariables z in consulta.SolutionVariables)
                {
                    listBox1.Items.Add(z["X"].ToString());
                }
            }
            
            if (chkEspecialista.Checked == true)
            {
                PlQuery consulta = new PlQuery("especialistade(X," + texto + ")");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                {
                    listBox1.Items.Add(z["X"].ToString());
                }
            }
        }


        private void Clear()
        {
            listBox1.Items.Clear();
        }


            //Load prolog file from hard disk
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

            // Prosessing a query
            //public string Query(string s)
            //{
            //    s.Trim();
            //    Regex r = new Regex(@"[A-Z_][a-zA-Z_]*");
            //    MatchCollection matches = r.Matches(s);
            //    string result = "";
            //    try
            //    {
            //        PlQuery q = new PlQuery(s);
            //        bool HasSolution = false;
            //        foreach (PlQueryVariables v in q.SolutionVariables)
            //        {
            //            HasSolution = true;
            //            foreach (Match match in matches)
            //            {
            //                result += v[match.ToString()].ToString() + " ; ";
            //            }
            //        }
            //        if (matches.Count == 0)
            //            return HasSolution ? "true" : "false";
            //        return result;
            //    }
            //    catch (SbsSW.SwiPlCs.Exceptions.PlException ex)
            //    {
            //        return "Error query: " + ex.Message;
            //    }
            //}

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
