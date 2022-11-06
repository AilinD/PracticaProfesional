using BLL.Business;
using DAL.Models;
//using DAL.Models;
using Services.BLL.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Medicos
{
    public partial class SolicitarEstudio : Form
    {
        public SolicitarEstudio()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEstudio_Click(object sender, EventArgs e)
        {
           
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void SolicitarEstudio_Load_1(object sender, EventArgs e)
        {
            cbocestudio.DataSource = EstudioBLL.Current.GetAll().Select(x => x.Nombre).ToList();

        }

        private void SolicitarEstudio_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            //int dniint = int.Parse(txtDniPaciente.Text);
            //var Search = PacienteBll.Current.GetAll().FirstOrDefault(x => x.DNI.Equals(dniint));
            //var usser = PacienteBll.Current.GetAll().Where(x => x.Apellido.Contains(txtDniPaciente.Text));
            var usser = PacienteBll.Current.GetAll().Where(x => x.Apellido.Contains(txtDniPaciente.Text));

            gridpaciente.DataSource = usser.ToList();
            //gridpaciente.DataSource = Search;
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            var paciente = new PacienteDto();
            int idpaciente =0;
            foreach (DataGridViewRow r in gridpaciente.SelectedRows)
            {
                idpaciente = (int)r.Cells["IdPaciente"].Value;
                paciente.DNI = (int)r.Cells["DNI"].Value;
                paciente.Nombre = r.Cells["Nombre"].Value.ToString();
                paciente.Apellido = r.Cells["Apellido"].Value.ToString();
                paciente.FechaNacimiento = (DateTime)r.Cells["FechaNacimiento"].Value;
               
            }

            var estudioPaciente = new EstudioPaciente();
            foreach (DataGridViewRow r in gridmedico.SelectedRows)
            {
                estudioPaciente.IdMedico = (int)r.Cells["IdMedico"].Value;
                estudioPaciente.IdPaciente = idpaciente;
                estudioPaciente.IdEstudio = cbocestudio.SelectedIndex;
                estudioPaciente.Fecha = DateTime.Now;
                estudioPaciente.Comentarios = txtComentarios.Text;
            }

            EstudioPacienteBLL.Current.InsertEstudioPaciente(estudioPaciente);
            MessageBox.Show("Estudio solicitado con éxito!");
        }

        private void btnBuscaMedico_Click(object sender, EventArgs e)
        {
            var usser = MedicoBLL.Current.GetAll().Where(x => x.Apellido.Contains(txtApellidoMedico.Text));
            //dataGridView1.DataSource = usser;
            gridmedico.DataSource = usser.ToList();
        }

        private void txtApellidoaciente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
