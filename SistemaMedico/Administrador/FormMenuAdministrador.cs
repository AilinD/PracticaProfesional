using DAL.Models;
using SistemaMedico.Extensions;

namespace UI.Administrador
{
    public partial class FormMenuAdministrador : Form
    {
       
        public FormMenuAdministrador()
        {
            IsMdiContainer = false;
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
            CreateMDIChild<EliminarPatente>();
        }

        private void agregarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NuevaPatente>();
       
        }

        private void modificarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<ModificarPatentes>();

        }
        
    

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Application.Exit();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateMDIChild<FormularioRestore>();
    
        }

        private void FormMenuAdministrador_Load(object sender, EventArgs e)
        {
            menuPatenteToolStripMenuItem.Translate();
            menuUsuariodToolStripMenuItem.Translate();
            BackupToolStripMenuItem.Translate();
            RestoreToolStripMenuItem1.Translate();
            agregarPatenteToolStripMenuItem.Translate();
            agregarUsuarioToolStripMenuItem.Translate();
            modificarPatenteToolStripMenuItem.Translate();
            modificarUsuarioToolStripMenuItem.Translate();
            eliminarPatenteToolStripMenuItem.Translate();
            eliminarUsuarioToolStripMenuItem.Translate();
            salirToolStripMenuItem2.Translate();
            salirToolStripMenuItem2.Translate();
            
            
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

        private void menuPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
