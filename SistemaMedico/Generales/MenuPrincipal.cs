
using iTextSharp.text;
using iTextSharp.text.pdf.qrcode;
using Services.BLL.PatenteBLL;
using Services.Domain;
using Services.Service;
using SistemaMedico.Extensions;
using SistemaMedico.Medicos;
using SistemaMedico.Recepcionista;
using SistemaMedico.Reportes;
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
//using Windows.Security.Authentication.Identity.Core;
using static System.Collections.Specialized.BitVector32;

namespace UI.Generales
{
    public partial class MenuPrincipal : Form
    {
        public readonly Sesion _sesion;
        public MenuPrincipal(Sesion sesion)
        {
            IsMdiContainer = false;
            GetSesion(sesion);
            _sesion = sesion;
            InitializeComponent();
        }

        public static void GetSesion(Sesion sesion)
        {

            var busqueda = PatenteBLL.GetAllAdapted();

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
            //SintomasToolStripMenuItem.Translate();
            reportesToolStripMenuItem.Translate();
            estudiosPorMedicoToolStripMenuItem.Translate();
            estudiosPorPacienteToolStripMenuItem.Translate();
            tamanio();
        }

        private void tamanio()
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //CreateMDIChild<FormMenuAdministrador>();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoPacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<NuevoPaciente>();
            }
            else if (!_sesion.usuario.Patente.Equals("Recepcionista") || (!_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
                nuevoPacienteToolStripMenuItem.Visible = false;
            }
               
        }


        private Form CreateMDIChildSession<T>() where T : Form
        {

            var childForm = (Form)Activator.CreateInstance(typeof(T), new object[] { _sesion });
            childForm.MdiParent = this;
            childForm.Text = string.Empty;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            return childForm;
        }

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


        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<ModificaPaciente>();
            }
            else if (!_sesion.usuario.Patente.Equals("Recepcionista") || (!_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
                modificarPacienteToolStripMenuItem.Visible=false;
            }
                
            
        }

        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<EliminarPaciente>();
            }
            else if (!_sesion.usuario.Patente.Equals("Recepcionista") || (!_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
            }
               
            
        }

        private void buscarCoincidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<BuscarCoincidencias>();
            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
                buscarCoincidenciasToolStripMenuItem.Visible = false;
            }
        }

        private void modificarDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<ModificarMedico>();
            }
            else if (!_sesion.usuario.Patente.Equals("Recepcionista") || (!_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
                modificarMedicoToolStripMenuItem.Visible = false;   
            }
                
        }

        private void agregarDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<NuevoMedico>();
            }
            else if (!_sesion.usuario.Patente.Equals("Recepcionista") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                agregarMedicoToolStripMenuItem.Visible = false;
            }
                
            
        }

        private void eliminarDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<EliminarMedico>();
            }
            else if (!_sesion.usuario.Patente.Equals("Recepcionista") || (!_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
                eliminarMedicoToolStripMenuItem.Visible = false;
            }
                
            
        }

        private void solicitarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChildSession<SolicitarEstudio>();
                //CreateMDIChild<SolicitarEstudio>();
            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                solicitarEstudioToolStripMenuItem.Visible = false;
            }
               
        }

        private void nuevaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<NuevaObraSocial>();

            }
            else if (!_sesion.usuario.Patente.Equals("Recepcionista") || (!_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
                nuevaObraSocialToolStripMenuItem.Visible = false;
            }

                
            
        }

        private void modificarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<ModificarObraSocial>();
            }
            else if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
                modificarObraSocialToolStripMenuItem.Visible = false;
            }
                
            
        }

        private void eliminarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Recepcionista") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<EliminarObraSocial>();
            }
            else if (!_sesion.usuario.Patente.Equals("Recepcionista") || (!_sesion.usuario.Patente.Equals("Administrador")))
            {
                eliminarObraSocialToolStripMenuItem.Visible = false;
                MessageBox.Show("No posee acceso para acceder");
            }
                
            
        }

        private void menuSintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<MenuSintomas>();
            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                menuSintomasToolStripMenuItem.Visible = false;
            }
                
        }

        private void informeDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChildSession<Diagnostico>();
            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                informeDiagnosticoToolStripMenuItem.Visible = false;
            }

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<NNuevoUsuario>();
            }
            else if (!_sesion.usuario.Patente.Equals("Administrador"))
            {
                MessageBox.Show("No posee acceso para acceder");
                agregarEstudioToolStripMenuItem.Visible = false;
            }
                
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<ModificarUsuario>();
            }
            else if(!_sesion.usuario.Patente.Equals("Administrador"))
            {
                MessageBox.Show("No posee acceso para acceder");
                modificarEstudioToolStripMenuItem.Visible = false;  
            }
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<EliminarUsuario>();
            }
            else if (!_sesion.usuario.Patente.Equals("Administrador"))

            {
                MessageBox.Show("No posee acceso para acceder");
                eliminarEstudioToolStripMenuItem.Visible = false;
            }
        }

        private void agregarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<NuevaPatente>();
            }
            else if (!_sesion.usuario.Patente.Equals("Administrador"))

            {
                MessageBox.Show("No posee acceso para acceder");
                agregarPatenteToolStripMenuItem.Visible = false;
            }
        }

        private void modificarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                
                CreateMDIChild<ModificarPatentes>();
            }
            else if(!_sesion.usuario.Patente.Equals("Administrador"))
            {
                MessageBox.Show("No posee acceso para acceder");
                modificarPacienteToolStripMenuItem.Visible = false;
            }
        }

        private void eliminarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<EliminarPatente>();
            }
            else if((!_sesion.usuario.Patente.Equals("Administrador")))
            {
                MessageBox.Show("No posee acceso para acceder");
                eliminarPatenteToolStripMenuItem.Visible = false;
            }
        }

        private void menuBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<FormularioBakup>();
            }
            else if (!_sesion.usuario.Patente.Equals("Administrador"))
            {
                menuBackupToolStripMenuItem.Visible = false;
                MessageBox.Show("No posee acceso para acceder");
            }

                
            
        }

        private void menuRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<FormularioRestore>();
            }
            else if (!_sesion.usuario.Patente.Equals("Administrador"))
            {
                MessageBox.Show("No posee acceso para acceder");
                menuRestoreToolStripMenuItem.Visible = false;
            } 
            
               
            
        }

        private void agregarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<NuevoEstudio>();
            }
            else if (!_sesion.usuario.Patente.Equals("Administrador"))
            {
                MessageBox.Show("No posee acceso para acceder");
                agregarEstudioToolStripMenuItem.Visible = false;
            }
                
            
        }

        private void modificarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<ModificarEstudio>();
            }
            else if (!_sesion.usuario.Patente.Equals("Administrador"))
            {
                MessageBox.Show("No posee acceso para acceder");
                modificarEstudioToolStripMenuItem.Visible = false;
            }
                
            
        }

        private void eliminarEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Administrador"))
            {
                CreateMDIChild<EliminarEstudio>();
            }
            else if (!_sesion.usuario.Patente.Equals("Administrador"))
            {
                MessageBox.Show("No posee acceso para acceder");
                eliminarEstudioToolStripMenuItem.Visible = false;
            }
                
           
        }

        private void estudiosPorDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<EstudiosXmedico>();
            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                estudiosPorMedicoToolStripMenuItem.Visible = false;
            }
        }

        private void estudiosPorPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<EstudiosXPaciente>();
            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                estudiosPorPacienteToolStripMenuItem.Visible = false;
            }
                
        }

        private void menuSintomasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<MenuSintomas>();


            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                menuSintomasToolStripMenuItem.Visible = false;
            }
        }

        private void historialPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChild<HistorialPaciente>();
            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                historialPacienteToolStripMenuItem.Visible = false;
            }

        }

        private void ingresarSintomasPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sesion.usuario.Patente.Equals("Medico") || (_sesion.usuario.Patente.Equals("Administrador")))
            {
                CreateMDIChildSession<IngresarSintomasPaciente>();
            }
            else if (!_sesion.usuario.Patente.Equals("Medico") || (!_sesion.usuario.Patente.Equals("Administrador")))

            {
                MessageBox.Show("No posee acceso para acceder");
                historialPacienteToolStripMenuItem.Visible = false;
            }
        }
    }

}
