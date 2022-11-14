
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
using static System.Collections.Specialized.BitVector32;

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

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<ModificaPaciente>();
        }

        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<EliminarPaciente>();
        }

        private void buscarCoincidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<BuscarCoincidencias>();
        }

        private void modificarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<ModificarMedico>();
        }

        private void agregarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<NuevoMedico>();
        }

        private void eliminarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<EliminarMedico>();
        }

        private void solicitarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<SolicitarEstudio>();
        }

        private void nuevaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<NuevaObraSocial>();
        }

        private void modificarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<ModificarObraSocial>();
        }

        private void eliminarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<EliminarObraSocial>();
        }

        private void menuSintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<MenuSintomas>();
        }

        private void informeDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMDIParent<Diagnostico>();
        }

      
    }
}
