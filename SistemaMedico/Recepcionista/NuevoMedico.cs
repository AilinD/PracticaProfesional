using BLL.Business;
using DAL.Repo;
using DAL.Models;
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

namespace SistemaMedico.Recepcionista
{
    public partial class NuevoMedico : Form
    {
        public NuevoMedico()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int Matricula = int.Parse(txtMatricula.Text);
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            string Domicilio = txtDomicilio.Text;
            string Contacto = txtContacto.Text;

            var medico = new MedicoDto()
            {
                Matricula = Matricula,
                Apellido = Apellido,
                Nombre = Nombre,
                Direccion = Domicilio,
                Contacto = Contacto


            };
            MedicoBLL.Current.Insert(medico);

            var medicoEspecialista = new MedicoPorEspecialidad();
            {
                var Search = MedicoBLL.Current.GetAll().FirstOrDefault(x => x.Apellido.Contains(txtApellido.Text));
                 cboxEspecialidad_SelectedIndexChanged( sender, e);
                medicoEspecialista.IdEspecialidad = cboxEspecialidad.SelectedIndex;
                medicoEspecialista.IdMedico = Search.IdMedico;
            }




            MedicoEspecialidadBLL.Current.InsertEspecialidadMedico(medicoEspecialista);

            MessageBox.Show("Medico insertado con éxito!");
        }

        private void NuevoMedico_Load(object sender, EventArgs e)
        {
            cboxEspecialidad.DataSource = EspecialidadBLL.Current.GetAll().ToList();
            cboxEspecialidad.DisplayMember = "Nombre";
            cboxEspecialidad.ValueMember = "Id";
            label4.Hide();
        }


        private void cboxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
