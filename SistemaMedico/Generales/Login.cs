using Services.BLL;
using Services.BLL.PatenteBLL;
using SistemaMedico.Extensions;
using System.Diagnostics.Tracing;
using UI.Generales;

namespace UI
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {


            if (BLLUsuario.TryLogin(txtUsuario.Text, txtContraseña.Text))
            {
                var isAuth = BLLUsuario.GetUsuarioByUserName(txtUsuario.Text);
                //SesionIniciada.usuario = isAuth.usuario;
                this.DialogResult = DialogResult.OK;

                //LoggerBLL.WriteLog("Logueando",EventLevel.Informational,isAuth.usuario.Nombre);
                MessageBox.Show("Login correcto!");
                this.Close();
                //MenuPrincipal menuPrincipal = new MenuPrincipal();
                //menuPrincipal.ShowDialog();
            }
            else
            {
                ShowError();
            }



        }
        private void ShowError(string error = "Nombre de usuario y/o contraseña incorrectos.")
        {
            MessageBox.Show(error);
            LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnIngreso.Translate();
            lblPass.Translate();
            lblBienvenido.Translate();
            lbUsuario.Translate();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
