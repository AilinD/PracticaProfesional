

using BLL.Business;
using DAL.Models;
//using DAL.Models;
using BLL.Dto;
using SistemaMedico.Recepcionista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Services.BLL;
using System.Diagnostics.Tracing;
using SistemaMedico.Extensions;
using Services.BLL.PatenteBLL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Domain;
using Services;

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
            //cboxSexo.DataSource = Sexo;
            cboxSexo.DisplayMember = "Value";
            cboxSexo.Items.Add("Femenino");
            cboxSexo.Items.Add("Masculino");
            
            cboxObraSocial.DataSource = ObraSocialBLL.Current.GetAll().Select(x => x.Nombre).ToList();
            cboxObraSocial.DisplayMember = "Nombre";
            //cboxObraSocial.ValueMember = "Id";
            
            lblApellido.Translate();
            lblNombre.Translate();
            lblDNI.Translate();
            lblFechaNac.Translate();
            lblObraSocial.Translate();
            lblDomicilio.Translate();
            lblSexo.Translate();
            lblContacto.Translate();
            btnAgregar.Translate();
            cboxSexo.Translate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DNI = int.Parse(txtDNI.Text);
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            DateTime FechaNac = dateTimePicker1.Value;
            string Domicilio = txtDomicilio.Text;
            string Contacto = txtContacto.Text;
            string Sexo = cboxSexo.Text;

            var busqueda = Existe(DNI);
            if (busqueda == true)
            {
                MessageBox.Show("Paciente ya existe");
                LoggerBLL.WriteLog("Paciente ya existe", EventLevel.Warning,Apellido+Nombre);
            }else if(busqueda == false)
            {
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
                PacienteBll.Current.Insert(paciente);
                int dniint = int.Parse(txtDNI.Text);
                var odp = new ObraSocialPaciente();
                {
                    var Search = PacienteBll.Current.GetAll().FirstOrDefault(x => x.DNI.Equals(dniint));
                    cboxObraSocial_SelectedIndexChanged(sender, e);
                    odp.IdPaciente = Search.IdPaciente;
                    odp.IdObraSocial = cboxObraSocial.SelectedIndex;
                };
                ObraSocialPacienteBLL.Current.InsertOsPaciente(odp);

                

                MessageBox.Show("Paciente insertado con éxito!");
                Limpiar();
            }
        
        }

        private void cboxObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       


        public bool Existe(int DNIPaciente)
        {
            var busqueda = PacienteBll.Current.GetAll().FirstOrDefault(x => x.DNI == DNIPaciente);
            if (busqueda != null)
            {
                return true;
            }
            return false;
        }

        private void Limpiar()
        {
            txtApellido.Clear();
            txtContacto.Clear();
            txtDNI.Clear();
            txtDomicilio.Clear();
            txtNombre.Clear();
            //dateTimePicker1= dateTimePicker1.TextChanged();
        }


    }
}
