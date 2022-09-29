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
    public partial class FormMenuAdministrador : Form
    {
        public FormMenuAdministrador()
        {
            InitializeComponent();
        }


        private void menuUsuariodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NNuevoUsuario>();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<FormularioBakup>();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<ModificarUsuario>();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<EliminarUsuario>();
           
        }

        private void eliminarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NuevaPatente>();
       
        }

        private void modificarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateMDIChild<FormularioRestore>();
    
        }

        private void FormMenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private Form CreateMDIChild<T>() where T : Form
        {

            var childForm = (Form)Activator.CreateInstance(typeof(T));
            childForm.Text = string.Empty;
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            return childForm;
        }
    }
}
