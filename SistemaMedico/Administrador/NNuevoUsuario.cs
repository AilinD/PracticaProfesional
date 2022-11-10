
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
            if (txtContraseña.Text.Equals(txtContra2.Text))
            {
                //var key = ConfigurationManager.AppSettings.Get("key");
                Usuario usuario = new Usuario();
                Familia familia = new Familia();
                familia.Nombre = cboxPatentes.SelectedItem.ToString();
                usuario.Nombre = txtNombre.Text;
                //usuario.Password = Hashing.EncryptString(key, txtContraseña.Text);



                _instance.Nombre = Convert.ToString(cboxPatentes.SelectedItem);
                PatenteBLL.Insert(_instance);
                familia.Add(_instance);
                BLLFamilia.Insert(familia);

                usuario.Permisos.Add(_instance);
                usuario.Permisos.Add(familia);
                BLLUsuario.Insert(usuario);

                this.Close();

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
            permisos.Add("administrador");
            permisos.Add("empleado");
            permisos.Add("reporteria");
            cboxPatentes.DataSource =  permisos;
            cboxPatentes.DisplayMember = "Value";

            btnGenerar.Translate();
            lblNombre.Translate();
            lblPass.Translate();
            lblRepitePass.Translate();
            lblSelecPat.Translate();

        }

        private void cboxPatentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

