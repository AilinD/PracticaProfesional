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
    public partial class ModificarUsuario : Form
    {
         #region singleton
        private readonly static ModificarUsuario _instance = new ModificarUsuario();
        public static ModificarUsuario Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {          
            

            if (txtNombreUsuario.Text != "")
            {
                
                DataTable dt = new DataTable();
                var user = BLLUsuario.Select(txtNombreUsuario.Text);
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Contraseña", typeof(string));
                dt.Columns.Add("IdUsuario", typeof(Guid));
                dt.Rows.Add(user["Nombre"], user["Contraseña"], user["IdUsuario"]);
                dataGridView1.DataSource = dt;

            }
                
            
            else
            {
                dataGridView1.DataSource = BLLUsuario.SelectAll();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnModificarUS_Click(object sender, EventArgs e)
        {
            var usuarioo = new ServiceLayer.Domain.PatenteFamilia.Usuario();

            
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                var busqueda = ServiceLayer.BLL.BLLUsuario.GetUsuarioByUserName(r.Cells["Nombre"].Value.ToString(), r.Cells["Contraseña"].Value.ToString());
                busqueda.usuario.Nombre = txtNuevoNombre.Text;
                busqueda.usuario.Password = txtNuevaPass.Text;
                busqueda.usuario.IdUsuario =r.Cells["IdUsuario"].Value.ToString();
                BLLUsuario.Update(busqueda.usuario);
                MessageBox.Show("Usuario Modificado con Éxito!");

            }
            
            
        }

        private void txtNuevaPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
