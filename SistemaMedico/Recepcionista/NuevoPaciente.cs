

using BLL.Business;
using Services.BLL.Dto;
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
            cboxObraSocial.DisplayMember = "Nombre";
            cboxObraSocial.ValueMember = "Id";
            cboxObraSocial.DataSource = ObraSocialBLL.Current.GetAll().Select(x=>x.Nombre).ToList();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DNI = int.Parse(txtDNI.Text);
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            DateTime FechaNac = dateTimePicker1.Value;
            string Domicilio = txtDomicilio.Text;
            string Contacto =txtContacto.Text;
            string Sexo = cboxSexo.Text;

            var os = ObraSocialBLL.Current.GetAll().Where(x => x.Nombre.Contains(cboxObraSocial.Text));
            //var xxx= ObraSocialBLL.Current.GetOne().Select(x => x.Nombre).ToList();

            //var idos = ObraSocialBLL.Current.GetAll().Select(x => x.Nombre == cboxObraSocial.Text);
            var paciente = new PacienteDto()
            {
                DNI = DNI,
                Apellido = Apellido,
                Nombre = Nombre,
                FechaNacimiento = FechaNac,
                Dirección = Domicilio,
                Contacto = Contacto,
                Sexo = Sexo,
                

            };
            //var ospaciente = new pacienteOS()
            //{
            
            //};
            //ObraSocialBLL.Current.Insert(ObraSocial);
            PacienteBll.Current.Insert(paciente);
            MessageBox.Show("Paciente insertado con éxito!");

        }

        private void cboxObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
