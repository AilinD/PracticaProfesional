
using iTextSharp.text;
using Services.Domain;
using SistemaMedico.Extensions;
using SistemaMedico.Medicos;
using SistemaMedico.Recepcionista;
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
using UI.Medicos;
using UI.Recepcionista;
using Windows.Security.Authentication.Identity.Core;
using static System.Collections.Specialized.BitVector32;

namespace UI.Generales
{
    public partial class MenuPrincipal : Form
    {
        private readonly Sesion _sesion;
        public MenuPrincipal(Sesion sesion)
        {
            IsMdiContainer = false;

            _sesion = sesion;
            InitializeComponent();
        }

        public Sesion GetSesion(Sesion sesion)
        {
            return _sesion;
        }

        private void btnMenuRecepcion_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuAdm_Click(object sender, EventArgs e)
        {
    
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            medicosToolStripMenuItem.Translate();
            menuAdministradorToolStripMenuItem.Translate();
            menuRecepcionToolStripMenuItem.Translate();
            salirToolStripMenuItem.Translate();
            agregarMedicoToolStripMenuItem.Translate();
            nuevoPacienteToolStripMenuItem.Translate();
            nuevoPacienteToolStripMenuItem1.Translate();
            nuevaObraSocialToolStripMenuItem.Translate();
            modificarMedicoToolStripMenuItem.Translate();
            modificarObraSocialToolStripMenuItem.Translate();
            modificarPacienteToolStripMenuItem.Translate();
            eliminarMedicoToolStripMenuItem.Translate();
            eliminarObraSocialToolStripMenuItem.Translate();
            eliminarPacienteToolStripMenuItem.Translate();
            diagnosticoPacientesToolStripMenuItem.Translate();
            informeDiagnosticoToolStripMenuItem.Translate();
            solicitarEstudioToolStripMenuItem.Translate();
            buscarCoincidenciasToolStripMenuItem.Translate();
            menuMedicosToolStripMenuItem.Translate();
            obrasSocialesToolStripMenuItem.Translate();
            diagnosticoPacientesToolStripMenuItem.Translate();
            SintomasToolStripMenuItem.Translate();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuAdministradorToolStripMenuItem_Click(object sender, EventArgs e) {

            //CreateMDIChild<FormMenuAdministrador>();
             
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoPacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NuevoPaciente>();
        }


        //private Form CreateMDIParent<T>() where T : Form
        //{

        //    var childForm = (Form)Activator.CreateInstance(typeof(T));
        //    childForm.Text = string.Empty;
        //    childForm.Dock = DockStyle.Fill;
        //    childForm.Show();
        //    return childForm;
        //}

        private Form CreateMDIChild<T>() where T : Form
        {

            var childForm = (Form)Activator.CreateInstance(typeof(T));
            //Activator.CreateInstance(Type, object[])
            //(Form)Activator.CreateInstance(typeof(T));
            childForm.MdiParent = this;
            childForm.Text = string.Empty;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            return childForm;
        }
        //public void mdiChild(Form mdiParent, Form mdiChild)
        //{
        //    foreach (Form frm in mdiParent.MdiChildren)
        //    {
        //        if (frm.Name == mdiChild.Name)
        //        {

        //            frm.Focus();
        //            return;
        //        }
        //    }

        //    mdiChild.MdiParent = mdiParent;
        //    mdiChild.Show();

        //}

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<ModificaPaciente>();
        }

        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<EliminarPaciente>();
        }

        private void buscarCoincidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<BuscarCoincidencias>();
        }

        private void modificarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<ModificarMedico>();
        }

        private void agregarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NuevoMedico>();
        }

        private void eliminarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<EliminarMedico>();
        }

        private void solicitarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<SolicitarEstudio>();
        }

        private void nuevaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NuevaObraSocial>();
        }

        private void modificarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<ModificarObraSocial>();
        }

        private void eliminarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<EliminarObraSocial>();
        }

        private void menuSintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<MenuSintomas>();
        }

        private void informeDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<Diagnostico>();

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NNuevoUsuario>();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<ModificarUsuario>();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<EliminarUsuario>();
        }

        private void agregarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NuevaPatente>();
        }

        private void modificarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<ModificarPatentes>();
        }

        private void eliminarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<EliminarPatente>();
        }

        private void menuBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<FormularioBakup>();
        }

        private void menuRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<FormularioRestore>();
        }

        private void agregarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<NuevoEstudio>();
        }

        private void modificarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<ModificarEstudio>();
        }

        private void eliminarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIChild<EliminarEstudio>();
        }
    }
}
