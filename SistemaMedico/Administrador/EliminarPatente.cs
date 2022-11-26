//using Domain;
using Services.BLL;
using Services.BLL.PatenteBLL;
using Services.Domain;
using Services.Service;
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

namespace UI.Administrador
{
    public partial class EliminarPatente : Form
    {
        public EliminarPatente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPatenteAEliminar.Text != "")
                {
                    DataTable dt = new DataTable();
                    var pat = PatenteBLL.Select(txtPatenteAEliminar.Text);
                    dt.Columns.Add("IdPatente", typeof(string));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Rows.Add(pat["IdPatente"], pat["Nombre"]);
                    dataGridView1.DataSource = dt;
                    //dataGridView1.Translate();

                }
                else
                {
                    dataGridView1.DataSource = PatenteBLL.SelectAll();
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
                var patente = new Patente();
                patente.Nombre = txtPatenteAEliminar.Text;
                Guid guid = Guid.Parse(dataGridView1.SelectedRows[0].Cells["IdPatente"].Value.ToString());
                patente.IdFamiliaElement = guid.ToString();
                //ServiceLayer.BLL.PatenteBLL.Select(guid.ToString());
                PatenteBLL.Delete(patente);
                MessageBox.Show("Patente eliminada");

                Limpiar();
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void EliminarPatente_Load(object sender, EventArgs e)
        {
            try
            {
                btnEliminar.Translate();
                btnBuscar.Translate();
                lblpatente.Translate();
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
            txtPatenteAEliminar.Text = "";
            dataGridView1.DataSource = null;
        }

    }
}
