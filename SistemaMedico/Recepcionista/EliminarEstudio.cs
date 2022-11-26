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
    public partial class EliminarEstudio : Form
    {
        public EliminarEstudio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtEstudioaEliminar.Text))
                {
                    var user = EstudioBLL.Current.GetAll();
                    dataGridView1.DataSource = user;
                    //dataGridView1.Translate();
                }
                else
                {
                    var usser = EstudioBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtEstudioaEliminar.Text));
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
                var estudio = new EstudioDto();

                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    estudio.Id = (int)r.Cells["Id"].Value;
                    estudio.Nombre = r.Cells["Nombre"].Value.ToString();


                    EstudioBLL.Current.Delete(estudio.Id);


                }
                MessageBox.Show("Estudio eliminado con éxito!");
                Limpiar();
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void EliminarEstudio_Load(object sender, EventArgs e)
        {

            try
            {
                string nombreform = this.Name;
                nombreform.Translate();
                lblEstudio.Translate();
                btnBuscar.Translate();
                btnEliminar.Translate();
                dataGridView1.DataSource = null;
                tamanio();
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void tamanio()
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Limpiar()
        {

            try
            {
                txtEstudioaEliminar.Text = "";
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }
    }
}
