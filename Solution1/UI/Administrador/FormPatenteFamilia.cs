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
    public partial class FormPatenteFamilia : Form
    {
        public FormPatenteFamilia()
        {
            InitializeComponent();
        }

        private void menuUsuariodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NNuevoUsuario nNuevoUsuario = new NNuevoUsuario();
            nNuevoUsuario.MdiParent=this;
            nNuevoUsuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarUsuario = new ModificarUsuario();
            modificarUsuario.MdiParent = this;
            modificarUsuario.Show();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario eliminarUsuario = new EliminarUsuario();
            eliminarUsuario.MdiParent = this;
            eliminarUsuario.Show();
        }

        private void eliminarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaPatente nuevaPatente = new NuevaPatente();
            nuevaPatente.MdiParent = this;
            nuevaPatente.Show();
        }

        private void modificarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
