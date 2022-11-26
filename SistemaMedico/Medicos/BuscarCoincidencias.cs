//using SbsSW.SwiPlCs;
using SbsSW.DesignByContract;
using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;
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
            try
            {

                Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\swipl");
                Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\swipl\bin");
                string[] p = { "-q", "-f", @"BaseProlog.pl" };
                PlEngine.Initialize(p);
                PlEngine.PlCleanup();

            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }




        }

        private void BuscarCoincidencias_Load(object sender, EventArgs e)
        {
            try
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
                chkenf.Translate();
                chkEspecialidades.Translate();
                chkEspecialista.Translate();
                chkSintomaDe.Translate();
                btnConsultar.Translate();
                btnLimpiar.Translate();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto1 = txtSintomas.Text;
                string txt2 = txtenfermedad.Text;
                string txt3 = txtxEspecialista.Text;
                string txt4 = txtespecialidades.Text;
                //string[] p = { "-q", "-f", @"BaseProlog.pl" };

                //PlEngine.Initialize(p);

                if (chkSintomaDe.Checked == true)
                {

                    try
                    {
                        var q = new PlQuery("sintomade", new PlTermV(new PlTerm(texto1), new PlTerm("X")));

                        foreach (PlTermV item in q.Solutions)
                        {
                            listBox1.Items.Add(item[1].ToString());
                        }

                    }
                    catch (Exception ex)
                    {

                        LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
                    }



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
                    PlQuery consulta = new PlQuery("especialistade(" + txt4 + ",X )");
                    foreach (PlQueryVariables z in consulta.SolutionVariables)
                    {
                        listBox1.Items.Add(z["X"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }


        }


        private void Clear()
        {
            listBox1.Items.Clear();
        }


        //Load prolog file from hard disk
        public void Load_file(string s)
        {
            try
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
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }
    }
}
