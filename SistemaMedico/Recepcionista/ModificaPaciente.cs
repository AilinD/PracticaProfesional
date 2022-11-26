using BLL;
using BLL.Business;
using BLL.Interfaces;
//using Domain;
using Microsoft.VisualBasic.ApplicationServices;
using BLL.Dto;
using Services.BLL.PatenteBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMedico.Extensions;
using Services.BLL;
using System.Diagnostics.Tracing;

namespace UI.Recepcionista
{
    public partial class ModificaPaciente : Form
    {

      
        public ModificaPaciente()
        {
            
            InitializeComponent();
        }
        
        

        private void ModificaPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                lblNuevoDomicilio.Translate();
                lblNuevoContacto.Translate();
                lblApellidoPaciente.Translate();
                btnBuscar.Translate();
                btnModificar.Translate();
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                var usser = PacienteBll.Current.GetAll().Where(x => x.Nombre.Contains(txtNombrePaciente.Text));


                var paciente = new PacienteDto();

                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {

                    paciente.IdPaciente = (int)r.Cells["IdPaciente"].Value;
                    paciente.DNI = (int)r.Cells["DNI"].Value;
                    paciente.Nombre = r.Cells["Nombre"].Value.ToString();
                    paciente.Apellido = r.Cells["Apellido"].Value.ToString();
                    paciente.FechaNacimiento = (DateTime)r.Cells["FechaNacimiento"].Value;
                    if (string.IsNullOrEmpty(txtNuevoDomicilio.Text))
                    {

                        paciente.Dirección = r.Cells["Dirección"].Value.ToString();
                    }
                    else
                    {
                        paciente.Dirección = txtNuevoDomicilio.Text;
                    }

                    if (string.IsNullOrEmpty(txtNuevoContacto.Text))
                    {
                        paciente.Contacto = r.Cells["Contacto"].Value.ToString();
                    }
                    else
                    {
                        paciente.Contacto = txtNuevoContacto.Text;
                    }
                    paciente.Sexo = r.Cells["Sexo"].Value.ToString();
                    PacienteBll.Current.Update(paciente);


                }
                MessageBox.Show("Paciente modificado con éxito!");
                Limpiar();
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }


        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombrePaciente.Text))
                {
                    var user = PacienteBll.Current.GetAll();
                    dataGridView1.DataSource = user;
                    //dataGridView1.Translate();
                }
                else
                {
                    var usser = PacienteBll.Current.GetAll().Where(x => x.Apellido.Contains(txtNombrePaciente.Text));
                    dataGridView1.DataSource = usser.ToList();
                    //dataGridView1.Translate();
                }
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Limpiar()
        {
            try
            {
                txtNombrePaciente.Text = "";
                txtNuevoContacto.Text = "";
                txtNuevoDomicilio.Text = "";
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
            
        }
    }
}
