using BLL.Business;
using BLL.Dto;
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
    public partial class EliminarMedico : Form
    {
        public EliminarMedico()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMedicoAEliminar.Text))
                {
                    var user = MedicoBLL.Current.GetAll();
                    dataGridView1.DataSource = user;
                    //dataGridView1.Translate();
                }
                else
                {
                    var usser = MedicoBLL.Current.GetAll().Where(x => x.Apellido.Contains(txtMedicoAEliminar.Text));
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
                var medico = new MedicoDto();

                var medicoespecialidad = new MedicoPorEspecialidadDto();

                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {

                    medico.IdMedico = (int)r.Cells["IdMedico"].Value;
                    medico.Matricula = (int)r.Cells["Matricula"].Value;
                    medico.Nombre = r.Cells["Nombre"].Value.ToString();
                    medico.Apellido = r.Cells["Apellido"].Value.ToString();
                    medico.Direccion = r.Cells["Direccion"].Value.ToString();
                    medico.Contacto = r.Cells["Contacto"].Value.ToString();

                    var search = MedicoEspecialidadBLL.Current.GetOne(medico.IdMedico);
                    if (search.Equals(null))
                    {
                        MessageBox.Show("Datos no encontrados");
                    }else if (search!=null)
                    {
                        medicoespecialidad.Id = search.Id;
                        medicoespecialidad.IdMedico = medico.IdMedico;
                        medicoespecialidad.IdEspecialidad = search.IdEspecialidad;
                        MedicoEspecialidadBLL.Current.Delete(medicoespecialidad.IdMedico);

                        MedicoBLL.Current.Delete(medico.IdMedico);
                        MessageBox.Show("Medico Eliminado con éxito!");
                        Limpiar();

                    }

                    Limpiar();
                }
               
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
                txtMedicoAEliminar.Text = "";
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                 
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void EliminarMedico_Load(object sender, EventArgs e)
        {
            try
            {
                lblApellidoMedico.Translate();
                btnEliminar.Translate();
                btnBuscar.Translate();
                dataGridView1.DataSource = null;
                tamanio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el backup");
                 
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
