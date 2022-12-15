using BLL.Business;
using BLL.Dto;
using DAL.Models;
using Services.BLL;
using Services.BLL.Exepciones;
using SistemaMedico.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico.Recepcionista
{
    public partial class EliminarPaciente : Form
    {
        public EliminarPaciente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPacienteAEliminar.Text))
                {
                    var user = PacienteBll.Current.GetAll();
                    dataGridView1.DataSource = user;
                    //dataGridView1.Translate();
                }
                else
                {
                    var usser = PacienteBll.Current.GetAll().Where(x => x.Apellido.Contains(txtPacienteAEliminar.Text));
                    //dataGridView1.DataSource = usser;
                    dataGridView1.DataSource = usser.ToList();
                    //dataGridView1.Translate();
                }
            }
            catch (Exception ex)
            {
                 
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var paciente = new PacienteDto();

                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {

                    var busqueda = PacienteBll.Current.GetOne((int)r.Cells["IdPaciente"].Value);
                    paciente.IdPaciente = (int)r.Cells["IdPaciente"].Value;
                    paciente.DNI = (int)r.Cells["DNI"].Value;
                    paciente.Nombre = r.Cells["Nombre"].Value.ToString();
                    paciente.Apellido = r.Cells["Apellido"].Value.ToString();
                    paciente.FechaNacimiento = (DateTime)r.Cells["FechaNacimiento"].Value;
                    paciente.Dirección = r.Cells["Dirección"].Value.ToString();
                    paciente.Contacto = r.Cells["Contacto"].Value.ToString();
                    paciente.Sexo = r.Cells["Sexo"].Value.ToString();


                    try
                    {

                        var searchOSPA = ObraSocialPacienteBLL.Current.GetOne(paciente.IdPaciente);
                        if (searchOSPA == null)
                        {
                            MessageBox.Show("Error , el paciente existe en alguna de las tablas");
                        }
                        else if(searchOSPA != null)
                        {
                            var odp = new ObraSocialPaciente();
                            {
                                odp.Id = searchOSPA.Id;
                                odp.IdPaciente = paciente.IdPaciente;
                                odp.IdObraSocial = searchOSPA.IdObraSocial;

                            };
                            ObraSocialPacienteBLL.Current.Delete(odp.IdPaciente);


                            PacienteBll.Current.Delete(paciente.IdPaciente);
                        }
                    }
                    catch (Exception ex)
                    {
                        ExceptionManager.Current.Handle(ex);
                         
                    }


                }
                MessageBox.Show("Paciente Eliminado con éxito!");
                Limpiar();
            }
            catch (Exception ex)
            {

                ExceptionManager.Current.Handle(ex);
            }
        }
        private void Limpiar()
        {
            try
            {
                txtPacienteAEliminar.Text = "";
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                 
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void EliminarPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                lblApellidoPaciente.Translate();
                btnBuscar.Translate();
                btnEliminar.Translate();
                dataGridView1.DataSource = null;
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
    }
}
