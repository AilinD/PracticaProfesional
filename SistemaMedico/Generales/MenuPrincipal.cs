
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Administrador;
using UI.Recepcionista;

namespace UI.Generales
{
    public partial class MenuPrincipal : Form
    {
       
        public MenuPrincipal()
        {
            IsMdiContainer = true;
            InitializeComponent();
        }
       

        private void btnMenuRecepcion_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuAdm_Click(object sender, EventArgs e)
        {
    
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuAdministradorToolStripMenuItem_Click(object sender, EventArgs e) {

            CreateMDIChild<FormMenuAdministrador>();
             
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoPacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateMDIParent<NuevoPaciente>();
        }


        private Form CreateMDIParent<T>() where T : Form
        {

            var childForm = (Form)Activator.CreateInstance(typeof(T));
            childForm.Text = string.Empty;
            childForm.MdiParent = this.MdiParent;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            return childForm;
        }

        private Form CreateMDIChild<T>() where T : Form
        {

            var childForm = (Form)Activator.CreateInstance(typeof(T));
            childForm.Text = string.Empty;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            return childForm;
        }
    }
}
