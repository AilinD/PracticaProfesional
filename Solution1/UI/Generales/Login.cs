using ServiceLayer.BLL;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Sesion SesionIniciada { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                var isAuth = BLLUsuario.GetUsuarioByUserName(textBox1.Text,textBox2.Text);
                SesionIniciada = isAuth;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login correcto!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
