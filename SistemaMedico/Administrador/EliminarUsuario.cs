//using Domain;
using BLL.Business;
using DAL.Models;
using Services.BLL;
using Services.BLL.Exepciones;
using Services.BLL.PatenteBLL;
using Services.Domain;
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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtUsuarioAEliminar.Text))
                {
                    DataTable dt = new DataTable();
                    var user = BLLUsuario.Select(txtUsuarioAEliminar.Text);
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Contraseña", typeof(string));
                    dt.Columns.Add("IdUsuario", typeof(Guid));
                    dt.Rows.Add(user["Nombre"], user["Contraseña"], user["IdUsuario"]);
                    dataGridView1.DataSource = dt;
                    //dataGridView1.Translate();
                }
                else
                {
                    dataGridView1.DataSource = BLLUsuario.SelectAll();
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
                var usuarioAEliminar = new Usuario();


                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    var busqueda = BLLUsuario.GetUsuarioByUserName(r.Cells["Nombre"].Value.ToString());
                    busqueda.usuario.Nombre = txtUsuarioAEliminar.Text;
                    busqueda.usuario.Password = r.Cells["Contraseña"].Value.ToString();
                    busqueda.usuario.IdUsuario = r.Cells["IdUsuario"].Value.ToString();
                    //Borramos la patente del usuario primero
                    // BLLUsuario.DeletePatentes(busqueda.usuario);

                   
                    BLLUsuario.Delete(busqueda.usuario);

                    MessageBox.Show("Usuario Eliminado con Éxito!");
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }

        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                lblNombreUsuario.Translate();
                btnBuscar.Translate();
                btnEliminar.Translate();
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
        private void Limpiar()
        {
            txtUsuarioAEliminar.Text = "";
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
