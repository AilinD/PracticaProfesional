using BLL.Business;
using Services.BLL;
using Services.BLL.PatenteBLL;
using SistemaMedico.Extensions;
using System.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Dto;
using Services.Domain;
using Services.Service;
using iTextSharp.text;
using Services.BLL.Exepciones;

namespace SistemaMedico.Medicos
{
    public partial class Diagnostico : Form
    {
        private static Sesion _sesion;
        public Diagnostico(Sesion sesion)
        {
            _sesion = sesion;
            InitializeComponent();

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                var diagnostico = new DiagnosticoDto();

                if (string.IsNullOrEmpty(txtComentarios.Text))
                {
                    MessageBox.Show("Por favor ingrese el diagnostico");
                }
                else
                {
                    foreach (DataGridViewRow r in gridpaciente.SelectedRows)
                    {


                        diagnostico.IdPaciente = (int)r.Cells["IdPaciente"].Value;
                        diagnostico.Fecha = DateTime.Now;
                        diagnostico.IdMedico = Convert.ToInt32(_sesion.usuario.IdRol);
                        diagnostico.diagnostico = txtComentarios.Text;


                        DiagnosticoBLL.Current.Insert(diagnostico);
                        MessageBox.Show("Diagnostico insertado con éxito!");
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }


        }
        private void Diagnostico_Load(object sender, EventArgs e)
        {
            try
            {
                //var isAuth = BLLUsuario.GetUsuarioByUserName();
                lblDiagnostico.Translate();
                lblApellidoPaciente.Translate();
                btnBuscar.Translate();
                btnGuardar.Translate();
                var permiso = SesionService.GetSesion(_sesion.usuario);
                tamanio();
            }
            catch (Exception ex)
            {

                ExceptionManager.Current.Handle(ex);
            }

        }

        private void tamanio()
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtApellidoPaciente.Text))
                {
                    var user = PacienteBll.Current.GetAll();
                    gridpaciente.DataSource = user;
                    //gridpaciente.Translate();
                }
                else
                {
                    var usser = PacienteBll.Current.GetAll().Where(x => x.Apellido.Contains(txtApellidoPaciente.Text));
                    gridpaciente.DataSource = usser.ToList();
                    //gridpaciente.Translate();
                }
            }
            catch (Exception ex)
            {

                ExceptionManager.Current.Handle(ex);

            }


        }

        private void Limpiar()
        {
            txtComentarios.Clear();
            txtApellidoPaciente.Clear();
            gridpaciente.DataSource = null;
        }

    }
}
