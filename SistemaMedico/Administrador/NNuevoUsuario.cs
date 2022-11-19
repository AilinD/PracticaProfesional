
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.BLL.PatenteBLL;
using System.Configuration;
using Services.Domain;
using SistemaMedico.Extensions;
using Services;
using BLL.Business;
using Services.BLL;
using System.Net;
using System.Diagnostics.Tracing;

namespace UI.Administrador
{
    public partial class NNuevoUsuario : Form
    {
        #region singleton
        private readonly static Patente _instance = new Patente();
        public static Patente Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        public NNuevoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var busqueda = Existe(txtNombre.Text);
            if (busqueda == true)
            {
                MessageBox.Show("Usario existente");
                LoggerBLL.WriteLog("Error al insertar nuevo usuario ya que el usuario existe", EventLevel.Warning, txtNombre.Text + "");
            }
            else if (busqueda == false)
            {
                if (txtContraseña.Text.Equals(txtContra2.Text))
                {
                    var key = ConfigurationManager.AppSettings.Get("key");
                    Usuario usuario = new Usuario();
                    Familia familia = new Familia();
                    familia.Nombre = cboxPatentes.SelectedItem.ToString();
                    usuario.Nombre = txtNombre.Text;
                    usuario.Password = Hashing.EncryptString(key, txtContraseña.Text);
                    usuario.IdUsuario= Guid.NewGuid().ToString();
                    usuario.IdRol = txtIdRol.Text;

                    _instance.Nombre = Convert.ToString(cboxPatentes.SelectedItem);
                    PatenteBLL.Insert(_instance);
                    familia.Add(_instance);
                    BLLFamilia.Insert(familia);

                    usuario.Permisos.Add(_instance);
                    usuario.Permisos.Add(familia);
                    BLLUsuario.Insert(usuario);
                    MessageBox.Show("Usuario Ingresado con exito!");
                    Limpiar();


                }


            }
        }

        private void NNuevoUsuario_Load(object sender, EventArgs e)
        {
            // Set to no text.
            //txtPassword.Text = "";
            // The password character is an asterisk.
            txtContraseña.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtContraseña.MaxLength = 14;
            txtContraseña.UseSystemPasswordChar = true;

            txtContra2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtContra2.MaxLength = 14;
            txtContra2.UseSystemPasswordChar = true;


            List<string> permisos = new List<string>();
            permisos.Add("Administrador");
            permisos.Add("Medico");
            permisos.Add("Recepcionista");
            //cboxPatentes.DataSource =  permisos;
            cboxPatentes.DisplayMember = "Value";
            cboxPatentes.Items.Add("Administrador");
            cboxPatentes.Items.Add("Medico");
            cboxPatentes.Items.Add("Recepcionista");
            btnGuardar.Translate();
            lblNombre.Translate();
            lblPass.Translate();
            lblRepitePass.Translate();
            lblSelecPat.Translate();
            //cboxPatentes.Translate();
            cboxPatentes.Translate();
        }

        public bool Existe(string nombreusuario)
        {
            var busqueda = BLLUsuario.GetUsuarioByUserName(txtNombre.Text);
            if (busqueda.usuario.IdUsuario == null)
            {
                return false;
            }
            return true;
        }

        private void cboxPatentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboxPatentes.Translate();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtContra2.Text = "";
            txtContraseña.Text = "";
            txtNombre.Text = "";
        }

        public void traduccion()
        {
            //Controls.OfType<Button>().Cast<Control>().ToList().ForEach(o => o.Text = o.Text.Translate());
            //foreach (DataGridView dgv in Controls.OfType<DataGridView>().Cast<DataGridView>().ToList())
            //{
            //    foreach (DataGridViewColumn column in dgv.Columns)
            //    {
            //        column.HeaderText = column.HeaderText.Translate();
            //    }
            //}
        }

        private void lblIdRol_Click(object sender, EventArgs e)
        {

        }

        private void txtIdRol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

