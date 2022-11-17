using Services.Domain;
using Services.BLL.PatenteBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMedico.Extensions;

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
                dataGridView1.Translate();
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
            btnModificar.Translate();
            btnBuscar.Translate();
            lblNuevaPass.Translate();
            lblNuevoNombre.Translate();
            lbUsuario.Translate();
            
        }

        private void btnModificarUS_Click(object sender, EventArgs e)
        {
            var usuarioo = new Usuario();

            
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                var busqueda = BLLUsuario.GetUsuarioByUserName(r.Cells["Nombre"].Value.ToString());
                if (string.IsNullOrEmpty(txtNuevoNombre.Text))
                {
                    busqueda.usuario.Nombre = r.Cells["Nombre"].Value.ToString();
                }
                else
                {
                    busqueda.usuario.Nombre = txtNuevoNombre.Text;
                }
                
                busqueda.usuario.Password = txtNuevaPass.Text;
                busqueda.usuario.IdUsuario =r.Cells["IdUsuario"].Value.ToString();
                BLLUsuario.Update(busqueda.usuario);
                MessageBox.Show("Usuario Modificado con Éxito!");
                Limpiar();
            }
            

        }

        private void txtNuevaPass_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txtNombreUsuario.Text = "";
            txtNuevaPass.Text = "";
            txtNuevoNombre.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
