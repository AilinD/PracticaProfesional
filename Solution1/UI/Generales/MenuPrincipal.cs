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
using UI.Administrador;
using UI.Recepcionista;

namespace UI.Generales
{
    public partial class MenuPrincipal : Form
    {
        private readonly Sesion _sesion;
        public MenuPrincipal(Sesion sesion)
        {
            IsMdiContainer = true;
            _sesion = sesion;
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

        private void menuAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<FormMenuAdministrador>();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoPacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NuevoPaciente>();
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
