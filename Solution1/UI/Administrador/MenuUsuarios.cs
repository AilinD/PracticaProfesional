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
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            NNuevoUsuario nNuevoUsuario = new NNuevoUsuario();
            nNuevoUsuario.ShowDialog();
            nNuevoUsuario.Hide();
        }
    }
}
