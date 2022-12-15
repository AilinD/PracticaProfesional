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
using Services.BLL;
using System.Diagnostics.Tracing;
using Services.BLL.Exepciones;

namespace UI.Administrador
{
    public partial class ModificarUsuario : Form
    {
         #region singleton
        //private readonly static ModificarUsuario _instance = new ModificarUsuario();
        private readonly static Patente _instance = new Patente();
        public static Patente Current
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

            try
            {

                if (!string.IsNullOrEmpty(txtNombreUsuario.Text))
                {

                    DataTable dt = new DataTable();
                    var user = BLLUsuario.Select(txtNombreUsuario.Text);
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Contraseña", typeof(string));
                    dt.Columns.Add("IdUsuario", typeof(Guid));
                    //dt.Columns.Add("IdRol", typeof(int));
                    dt.Rows.Add(user["Nombre"], user["Contraseña"], user["IdUsuario"]/*, user["IdRol"]*/);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            try
            {

                btnModificar.Translate();
                btnBuscar.Translate();
                lblNuevaPass.Translate();
                lblNuevoNombre.Translate();
                lbUsuario.Translate();
                lblIdRol.Translate();
                tamanio();


                List<string> permisos = new List<string>();
                permisos.Add("Administrador");
                permisos.Add("Medico");
                permisos.Add("Recepcionista");
                //cboxPatentes.DataSource =  permisos;
                cboxPatentes.DisplayMember = "Value";
                cboxPatentes.Items.Add("Administrador");
                cboxPatentes.Items.Add("Medico");
                cboxPatentes.Items.Add("Recepcionista");
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

        private void btnModificarUS_Click(object sender, EventArgs e)
        {
            try
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
                    if (string.IsNullOrEmpty(txtIdRol.Text))
                    {
                        busqueda.usuario.IdRol = (int)r.Cells["IdRol"].Value;
                    }
                    else
                    {
                        busqueda.usuario.IdRol = Convert.ToInt16(txtIdRol.Text);
                    }

                    busqueda.usuario.Password = txtNuevaPass.Text;
                    busqueda.usuario.IdUsuario = r.Cells["IdUsuario"].Value.ToString();
                    //busqueda.usuario.Patente = cboxPatentes.SelectedItem.ToString();
                    if (busqueda.usuario.IdPatente == null)
                    {
                        Familia familia = new Familia();
                        familia.Nombre = cboxPatentes.SelectedItem.ToString();
                        _instance.Nombre = Convert.ToString(cboxPatentes.SelectedItem);
                        PatenteBLL.Insert(_instance);
                        familia.Add(_instance);
                        BLLFamilia.Insert(familia);

                        busqueda.usuario.Permisos.Add(_instance);
                        busqueda.usuario.Permisos.Add(familia);
                    }

                    BLLUsuario.Update(busqueda.usuario);
                    MessageBox.Show("Usuario Modificado con Éxito!");
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
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
            txtIdRol.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
