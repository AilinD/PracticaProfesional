using Microsoft.SqlServer.Management.XEvent;
using ServiceLayer.BLL;
using ServiceLayer.Domain.PatenteFamilia;
using ServiceLayer.Servicios.Hash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Administrador;

namespace UI
{
    public partial class Login : Form
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
        public Sesion SesionIniciada { get; set; }
        public Login()
        {
            SesionIniciada = new Sesion();

            InitializeComponent();
  
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
    

            if(BLLUsuario.TryLogin(txtUsuario.Text, txtContraseña.Text))
            {
                    var isAuth = BLLUsuario.GetUsuarioByUserName(txtUsuario.Text, txtContraseña.Text);
                SesionIniciada.usuario = isAuth.usuario;
                this.DialogResult = DialogResult.OK;
                this.Close();
                LoggerBLL.WriteLog("Logueando",EventLevel.Informational,isAuth.usuario.Nombre);
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
            LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");
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
