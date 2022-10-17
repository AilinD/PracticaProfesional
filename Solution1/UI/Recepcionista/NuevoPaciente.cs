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



            DateTime date = dateTimePicker1.Value;
            string nombreSP = "Sp_CboxObraSocial";
            cboxObraSocial.DataSource= PacienteBLL.Current.LLenarCbox(nombreSP);
            cboxObraSocial.DisplayMember = "ObraSocial";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DNI = int.Parse(txtDNI.Text);
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            string FechaNac = dateTimePicker1.Text;
            string Domicilio = txtDomicilio.Text;
            int Contacto =int.Parse(txtContacto.Text);
            string Sexo = cboxSexo.Text;
            string ObraSocial = cboxObraSocial.Text;

            PacienteBLL.Current.Call(DNI, Apellido, Nombre, FechaNac, Domicilio, Contacto, Sexo, ObraSocial);
            //_instance.AltaPaciente();
            

        }

        private void cboxObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
