using ServiceLayer.BLL;
using System.Diagnostics.Tracing;

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
    

            if(BLLUsuario.TryLogin(txtUsuario.Text, txtContraseña.Text))
            {
                    var isAuth = BLLUsuario.GetUsuarioByUserName(txtUsuario.Text);
                //SesionIniciada.usuario = isAuth.usuario;
                this.DialogResult = DialogResult.OK;
                this.Close();
                //LoggerBLL.WriteLog("Logueando",EventLevel.Informational,isAuth.usuario.Nombre);
                    MessageBox.Show("Login correcto!");
                    

            }
            else
            {
                ShowError();
            }

            

        }
        private  void ShowError(string error = "Nombre de usuario y/o contraseña incorrectos.")
        {
            MessageBox.Show(error);
            //LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");
        }

        private void Login_Load(object sender, EventArgs e)
        {
       

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
