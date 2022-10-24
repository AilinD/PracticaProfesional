using BLL;
using BLL.Business;
using BLL.Interfaces;
using Domain;
using Microsoft.VisualBasic.ApplicationServices;
using Services.BLL.Dto;
using Services.BLL.PatenteBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Recepcionista
{
    public partial class ModificaPaciente : Form
    {

      
        public ModificaPaciente()
        {
            
            InitializeComponent();
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
            if (string.IsNullOrEmpty(txtNombrePaciente.Text))
            {
                var user = PacienteBll.Current.GetAll();
                dataGridView1.DataSource = user;
            }
            else
            {
                var usser = PacienteBll.Current.GetAll().Where(x=>x.Nombre.Contains(txtNombrePaciente.Text));
                //dataGridView1.DataSource = usser;
                dataGridView1.DataSource = usser.ToList();
            }
                
        }
    }
}
