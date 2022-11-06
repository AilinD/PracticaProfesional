//using SbsSW.SwiPlCs;
using SbsSW.DesignByContract;
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

            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\swipl");
            Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\swipl\bin");
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
            string texto1 = txtSintomas.Text;
            string txt2 = txtenfermedad.Text;
            string txt3 = txtxEspecialista.Text;
            string txt4 = txtespecialidades.Text;
            //string[] p = { "-q", "-f", @"BaseProlog.pl" };

            //PlEngine.Initialize(p);
                 
            if (chkSintomaDe.Checked == true)
            {
                //var q = new PlQuery("sintomade", new PlTermV(new PlTerm("X"), new PlTerm("gripe")));

                var q = new PlQuery("sintomade", new PlTermV(new PlTerm(texto1), new PlTerm("X")));

                foreach (PlTermV item in q.Solutions)
                {                    
                    listBox1.Items.Add(item[1].ToString());
                }


                /*string query = $"sintomade(X,[gripe])";

                //PlQuery consulta = new PlQuery();
                PlTerm term = PlQuery.PlCallQuery(query);

                Console.WriteLine(term.IsList);

                foreach (PlTerm item in term)
                {
                    Console.WriteLine(term.ToString());
                }*/

                //consulta.NextSolution();

                /*using (PlTerm q = PlQuery.PlCallQuery(query))//"sintomade(Y,X), atomic_list_concat([Y,' es sintoma de ',X], L)"))
                {
                    foreach (var item in q.Solutions)
                    {
                        listBox1.Items.Add(q.Args[0].ToString());                        
                    }                    
                } */
                
            }
            
            if (chkEspecialista.Checked == true)
            {
                PlQuery consulta = new PlQuery("especialistade(X," + txt3 + ")");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                {
                    listBox1.Items.Add(z["X"].ToString());
                }
                
            }

            if (chkenf.Checked == true)
            {
                var q = new PlQuery("sintomade", new PlTermV(new PlTerm("X"), new PlTerm(txt2)));

                foreach (PlTermV item in q.Solutions)
                {
                    listBox1.Items.Add(item[0].ToString());
                }
                

            }

            if (chkEspecialidades.Checked == true)
            {
                PlQuery consulta = new PlQuery("especialistade("+txt4 + ",X )");
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
            chkEspecialista.Checked = false;
            chkenf.Checked = false;
            chkSintomaDe.Checked = false;
            chkEspecialidades.Checked = false;  
            txtxEspecialista.Text = "";
            txtSintomas.Text = "";
            txtenfermedad.Text = "";
            txtespecialidades.Text = "";
            Clear();
        }
    }
}
