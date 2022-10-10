using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Recepcionista
{
    public partial class NuevoPaciente : Form
    {

        #region singleton
        private readonly static PacienteBLL _instance = new PacienteBLL();
        public static PacienteBLL Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        public NuevoPaciente()
        {
            InitializeComponent();
        }

        private void NuevoPaciente_Load(object sender, EventArgs e)
        {
            List<string> Sexo = new List<string>();
            Sexo.Add("Femenino");
            Sexo.Add("Masculino");
            cboxSexo.DataSource = Sexo;
            cboxSexo.DisplayMember = "Value";

            List<string> ObraSocial = new List<string>();
            ObraSocial.Add("Swiss");
            ObraSocial.Add("Osde");
            ObraSocial.Add("Sancor");
            ObraSocial.Add("Medicus");
            ObraSocial.Add("Accord");
            cboxObraSocial.DataSource = ObraSocial;
            cboxObraSocial.DisplayMember = "Value";

            DateTime date = dateTimePicker1.Value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_instance.AltaPaciente();
            

        }
    }
}
