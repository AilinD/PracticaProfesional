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
    public partial class EliminarObraSocial : Form
    {
        public EliminarObraSocial()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOSaEliminar.Text))
                {
                    var user = ObraSocialBLL.Current.GetAll();
                    dataGridView1.DataSource = user;
                    //dataGridView1.Translate();
                }
                else
                {
                    var usser = ObraSocialBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtOSaEliminar.Text));
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
                var obrasocial = new ObraSocialDto();

                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    obrasocial.Id = (int)r.Cells["Id"].Value;
                    obrasocial.Nombre = r.Cells["Nombre"].Value.ToString();


                    ObraSocialBLL.Current.Delete(obrasocial.Id);


                }
                MessageBox.Show("Obra Social eliminada con éxito!");
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
                txtOSaEliminar.Text = "";
                dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                 
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void EliminarObraSocial_Load(object sender, EventArgs e)
        {
            try
            {
                lblObraSocial.Translate();
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
