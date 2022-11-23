using BLL.Business;
using BLL.Dto;
using Services.Domain;
using SistemaMedico.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico.Medicos
{
    public partial class IngresarSintomasPaciente : Form
    {
        private static Sesion _sesion;
        public IngresarSintomasPaciente(Sesion sesion)
        {
            _sesion = sesion;
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var sintomasPaciente = new DAL.Models.SintomaPaciente();

            foreach (DataGridViewRow r in gridPaciente.SelectedRows)
            {
                sintomasPaciente.Fecha=DateTime.Now;
                sintomasPaciente.IdPaciente = (int)r.Cells["IdPaciente"].Value;
                sintomasPaciente.IdMedico = Convert.ToInt32(_sesion.usuario.IdRol); ;
                
               
            }

            foreach (DataGridViewRow r in gridSintoma.SelectedRows)
            { 
                sintomasPaciente.IdSintoma = (int)r.Cells["IdSintoma"].Value;
            }
            SintomaPacienteBLL.Current.InsertSintomaPaciente(sintomasPaciente);
            MessageBox.Show("Sintoma Paciente ingresdo con exito!");

            Limpiar();
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombrePaciente.Text))
            {
                var user = PacienteBll.Current.GetAll();
                gridPaciente.DataSource = user;
                //gridPaciente.Translate();
            }
            else
            {
                var usser = PacienteBll.Current.GetAll().Where(x => x.Apellido.Contains(txtNombrePaciente.Text));
                gridPaciente.DataSource = usser.ToList();
                //gridPaciente.Translate();
            }
        }

        private void Limpiar()
        {
            txtNombrePaciente.Text = "";
            gridPaciente.DataSource = null;
            gridSintoma.DataSource = null;
        }

        private void SintomasPaciente_Load(object sender, EventArgs e)
        {
            lblApellidoPaciente.Translate();
            lblSintomas.Translate();
            btnGuardar.Translate();
            btnBusca.Translate();
            btnBuscar.Translate();
 
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSintoma.Text))
            {
                var user = SintomaBLL.Current.GetAll();
                gridSintoma.DataSource = user;
                //gridPaciente.Translate();
            }
            else
            {
                var usser = SintomaBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtSintoma.Text));
                gridSintoma.DataSource = usser.ToList();
                //gridPaciente.Translate();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
