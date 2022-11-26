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
using static System.Net.Mime.MediaTypeNames;

namespace SistemaMedico.Recepcionista
{
    public partial class ModificarObraSocial : Form
    {
        public ModificarObraSocial()
        {
            InitializeComponent();
        }

        private void btnBuscaMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtObraSocial.Text))
                {
                    var user = ObraSocialBLL.Current.GetAll();
                    dataGridView1.DataSource = user;
                    //dataGridView1.Translate();

                }
                else
                {
                    var usser = ObraSocialBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtObraSocial.Text));
                    dataGridView1.DataSource = usser.ToList();
                    //dataGridView1.Translate();
                }
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                var obrasocial = new ObraSocialDto();

                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    obrasocial.Id = (int)r.Cells["Id"].Value;
                    obrasocial.Nombre = txtNuevoNombre.Text;


                    ObraSocialBLL.Current.Update(obrasocial);


                }
                MessageBox.Show("Obra Social modificada con éxito!");
                txtNuevoNombre.Text = "";
                txtObraSocial.Text = "";
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void ModificarObraSocial_Load(object sender, EventArgs e)
        {
            try
            {
                lblNuevoNombre.Translate();
                lblObraSocial.Translate();
                btnBuscar.Translate();
                btnModificar.Translate();
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


    }
}
