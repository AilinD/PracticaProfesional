using BLL.Business;
using DAL.Models;
//using DAL.Models;
using BLL.Dto;
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
using SistemaMedico.Extensions;
using Services.Domain;
using Services.BLL;
using System.Diagnostics.Tracing;
using Services.BLL.Exepciones;

namespace UI.Medicos
{
    public partial class SolicitarEstudio : Form
    {
        private static Sesion _sesion;
        public SolicitarEstudio(Sesion sesion)
        {
            _sesion = sesion;
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
            try
            {
                cbocestudio.DataSource = EstudioBLL.Current.GetAll().Select(x => x.Nombre).ToList();
                //lblApellidoMedico.Translate();
                lblComentarios.Translate();
                lblDNI.Translate();
                lblSeleccionaEstudio.Translate();
                btnBusca.Translate();
                //btnBusca1.Translate();
                btnBuscar.Translate();
                btnModificar.Translate();
                btnEstudio.Translate();
                //cboxEstudio.Translate();
                tamanio();
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void tamanio()
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
        }

        private void SolicitarEstudio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDniPaciente.Text!=null)
                {
                    int dniint = int.Parse(txtDniPaciente.Text);
                    var usser = PacienteBll.Current.GetAll().Where(x => x.DNI.Equals(dniint));

                    gridpaciente.DataSource = usser.ToList(); 
                }else if(txtDniPaciente.Text != null)
                {
                    MessageBox.Show("Ingrese el dni del paciente por favor");
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {

            try
            {
                var estudioPaciente = new EstudioPacienteDto();
                foreach (DataGridViewRow r in gridpaciente.SelectedRows)
                {
                    estudioPaciente.IdMedico = Convert.ToInt32(_sesion.usuario.IdRol);
                    estudioPaciente.IdPaciente = (int)r.Cells["IdPaciente"].Value;
                    estudioPaciente.IdEstudio = cbocestudio.SelectedIndex;
                    estudioPaciente.Fecha = DateTime.Now;
                    estudioPaciente.Comentarios = txtComentarios.Text;
                }

                EstudioPacienteBLL.Current.Insert(estudioPaciente);
                MessageBox.Show("Estudio solicitado con éxito!");
                Limpiar();
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
                 
            }
        }

        private void btnBuscaMedico_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidoaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtApellidoPaciente.Text = "";
            txtComentarios.Text = "";
            txtDniPaciente.Text = "";
            dataGridView1.DataSource = null;
            gridpaciente.DataSource = null;
        }
    }
}
