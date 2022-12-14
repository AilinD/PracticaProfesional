using ServiceLayer.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DataTable dt = new DataTable();
            var user = BLLUsuario.Select(txtUsuarioAEliminar.Text);
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Contraseña", typeof(string));
            dt.Columns.Add("IdUsuario", typeof(Guid));
            dt.Rows.Add(user["Nombre"], user["Contraseña"], user["IdUsuario"]);
            dataGridView1.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var usuarioAEliminar = new ServiceLayer.Domain.PatenteFamilia.Usuario();


            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                var busqueda = ServiceLayer.BLL.BLLUsuario.GetUsuarioByUserName(r.Cells["Nombre"].Value.ToString(), r.Cells["Contraseña"].Value.ToString());
                busqueda.usuario.Nombre = txtUsuarioAEliminar.Text;
                busqueda.usuario.Password = r.Cells["Contraseña"].Value.ToString();
                busqueda.usuario.IdUsuario = r.Cells["IdUsuario"].Value.ToString();
                //Borramos la patente del usuario primero
               // BLLUsuario.DeletePatentes(busqueda.usuario);
                BLLUsuario.Delete(busqueda.usuario);
                MessageBox.Show("Usuario Eliminado con Éxito!");

            }

        }
    }
}
