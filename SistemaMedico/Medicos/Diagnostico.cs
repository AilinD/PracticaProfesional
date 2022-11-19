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
            string comentario = txtComentarios.Text;
            var diagnostico = new DiagnosticoDto();

            string nombremedico = (_sesion.usuario.Nombre);
            string[] separacion = nombremedico.Split('.');
           
            //var Apellidomedico = (_sesion.usuario.Permisos);
            
            string nombreM = separacion.GetValue(0).ToString();
            string ApellidoM = separacion.GetValue(1).ToString();


            var m= MedicoBLL.Current.GetAll().FirstOrDefault(x => x.Apellido == ApellidoM);
            
            if (m.Nombre.Equals( nombreM))
            {
                foreach (DataGridViewRow r in gridpaciente.SelectedRows)
                {


                    diagnostico.IdPaciente = (int)r.Cells["IdPaciente"].Value;
                    diagnostico.Fecha = DateTime.Now;
                    diagnostico.IdMedico = m.IdMedico;
                    diagnostico.diagnostico = txtComentarios.Text;


                    DiagnosticoBLL.Current.Insert(diagnostico);
                    MessageBox.Show("Diagnostico insertado con éxito!");
                    Limpiar();

                }
            }
           
        }
        private void Diagnostico_Load(object sender, EventArgs e)
        {
            //var isAuth = BLLUsuario.GetUsuarioByUserName();
            lblDiagnostico.Translate();
            lblApellidoPaciente.Translate();
            btnBuscar.Translate();
            btnGuardar.Translate();
            var permiso = SesionService.GetSesion(_sesion.usuario);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtApellidoPaciente.Text))
            {
                var user = PacienteBll.Current.GetAll();
                gridpaciente.DataSource = user;
                gridpaciente.Translate();
            }
            else
            {
                var usser = PacienteBll.Current.GetAll().Where(x => x.Apellido.Contains(txtApellidoPaciente.Text));
                gridpaciente.DataSource = usser.ToList();
                gridpaciente.Translate();
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
