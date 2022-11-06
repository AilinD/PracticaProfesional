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

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            var usser = PacienteBll.Current.GetAll().Where(x => x.Nombre.Contains(txtNombrePaciente.Text));


            var paciente = new PacienteDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {

                //var busqueda = PacienteBll.Current.GetOne((int)r.Cells["IdPaciente"].Value);
                paciente.IdPaciente = (int)r.Cells["IdPaciente"].Value;
                paciente.DNI = (int)r.Cells["DNI"].Value;
                paciente.Nombre = r.Cells["Nombre"].Value.ToString();
                paciente.Apellido = r.Cells["Apellido"].Value.ToString();
                paciente.FechaNacimiento = (DateTime)r.Cells["FechaNacimiento"].Value;
                if (string.IsNullOrEmpty(txtNuevoDomicilio.Text))
                {
                    
                    paciente.Dirección = r.Cells["Dirección"].Value.ToString();
                }
                else
                {
                    paciente.Dirección = txtNuevoDomicilio.Text;
                }

                if (string.IsNullOrEmpty(txtNuevoContacto.Text))
                {
                    paciente.Contacto = r.Cells["Contacto"].Value.ToString();
                }
                else
                {
                    paciente.Contacto = txtNuevoContacto.Text;
                }                  
                paciente.Sexo = r.Cells["Sexo"].Value.ToString();
                PacienteBll.Current.Update(paciente);
                

            }
            MessageBox.Show("Paciente modificado con éxito!");


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
                var usser = PacienteBll.Current.GetAll().Where(x => x.Nombre.Contains(txtNombrePaciente.Text));
                //dataGridView1.DataSource = usser;
                dataGridView1.DataSource = usser.ToList();
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
