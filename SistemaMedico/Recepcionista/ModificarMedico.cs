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
    public partial class ModificarMedico : Form
    {
        public ModificarMedico()
        {
            InitializeComponent();
        }

        private void btnBuscaMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtApellidoMedico.Text))
                {
                    var user = MedicoBLL.Current.GetAll();
                    dataGridView1.DataSource = user;
                    //dataGridView1.Translate();
                }
                else
                {
                    var usser = MedicoBLL.Current.GetAll().Where(x => x.Apellido.Contains(txtApellidoMedico.Text));
                    dataGridView1.DataSource = usser;
                    dataGridView1.DataSource = usser.ToList();
                    //dataGridView1.Translate();
                }
            }
            catch (Exception ex)
            {
                 
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {
            try
            {

                var medico = new MedicoDto();

                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    medico.IdMedico = (int)r.Cells["IdMedico"].Value;
                    medico.Matricula = (int)r.Cells["Matricula"].Value;
                    medico.Nombre = r.Cells["Nombre"].Value.ToString();
                    medico.Apellido = r.Cells["Apellido"].Value.ToString();

                    if (string.IsNullOrEmpty(txtNuevoDomicilio.Text))
                    {

                        medico.Direccion = r.Cells["Direccion"].Value.ToString();
                    }
                    else
                    {
                        medico.Direccion = txtNuevoDomicilio.Text;
                    }

                    if (string.IsNullOrEmpty(txtNuevoContacto.Text))
                    {
                        medico.Contacto = r.Cells["Contacto"].Value.ToString();
                    }
                    else
                    {
                        medico.Contacto = txtNuevoContacto.Text;
                    }

                    MedicoBLL.Current.Update(medico);


                }
                MessageBox.Show("Medico modificado con éxito!");
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
                txtApellidoMedico.Text = "";
                txtNuevoContacto.Text = "";
                txtNuevoDomicilio.Text = "";
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
                 
            }
        }

        private void ModificarMedico_Load(object sender, EventArgs e)
        {
            try
            {
                lblApellidoMedico.Translate();
                lblNuevoContacto.Translate();
                lblNuevoDomicilio.Translate();
                btnBuscar.Translate();
                btnModificar.Translate();
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
