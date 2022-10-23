using BLL;
using BLL.Interfaces;
using Domain;
using Services.BLL.Dto;
using Services.BLL.PatenteBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Recepcionista
{
    public partial class ModificaPaciente : Form
    {
        private readonly IGenericBusiness<PacienteDto> _PatientService;

      
        public ModificaPaciente(IGenericBusiness<PacienteDto> genericBusiness)
        {
            
            InitializeComponent();
            _PatientService = genericBusiness;
        }
        
        

        private void ModificaPaciente_Load(object sender, EventArgs e)
        {

        }

        private  void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            var paciente = new PacienteDto();
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                //PatientService.GetAll(paciente);
                //busqueda..Nombre = txtNuevoNombre.Text;
                //busqueda.usuario.Password = txtNuevaPass.Text;
                //busqueda.usuario.IdUsuario = r.Cells["IdUsuario"].Value.ToString();
                //PatientService.Current.Update(paciente.DNI);
                MessageBox.Show("Paciente Modificado con Éxito!");

            }
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
             var user = _PatientService.GetAll();
            //dt.Columns.Add("Nombre", typeof(string));
            //dt.Columns.Add("Contraseña", typeof(string));
            //dt.Columns.Add("IdUsuario", typeof(Guid));
            //dt.Rows.Add(user["Nombre"], user["Contraseña"], user["IdUsuario"]);
            //dataGridView1.DataSource = dt;
        }
    }
}
