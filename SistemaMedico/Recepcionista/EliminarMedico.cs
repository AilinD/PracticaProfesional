using BLL.Business;
using BLL.Dto;
using Services.BLL;
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

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                    medico.Direccion = r.Cells["Direccion"].Value.ToString();
                    medico.Contacto = r.Cells["Contacto"].Value.ToString();
                    MedicoBLL.Current.Delete(medico.IdMedico);


                }
                MessageBox.Show("Medico Eliminado con éxito!");
                Limpiar();
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
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

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
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
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }
    }
}
