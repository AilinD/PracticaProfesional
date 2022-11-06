using BLL.Business;
using Services.BLL.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico.Recepcionista
{
    public partial class ModificarMedico : Form
    {
        public ModificarMedico()
        {
            InitializeComponent();
        }

        private void btnBuscaMedico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellidoMedico.Text))
            {
                //var user = MedicoBLL.Current.GetAll();
                //dataGridView1.DataSource = user;
            }
            else
            {
                //var usser = MedicoBLL.Current.GetAll().Where(x => x.Apellido.Contains(txtApellidoMedico.Text));
                //dataGridView1.DataSource = usser;
                //dataGridView1.DataSource = usser.ToList();
            }
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {

            var medico = new MedicoDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                medico.IdMedico = (int)r.Cells["Id"].Value;
                medico.Matricula = (int)r.Cells["Matricula"].Value;
                medico.Nombre = r.Cells["Nombre"].Value.ToString();
                medico.Apellido = r.Cells["Apellido"].Value.ToString();
                
                if (string.IsNullOrEmpty(txtNuevoDomicilio.Text))
                {

                    medico.Direccion = r.Cells["Dirección"].Value.ToString();
                }
                else
                {
                    medico.Direccion = txtNuevoDomicilio.Text;
                }

                if (string.IsNullOrEmpty(txtNuevoContacto.Text))
                {
                    medico.Contacto = r.Cells["Contacto"].Value.ToString();
                }
                else
                {
                    medico.Contacto = txtNuevoContacto.Text;
                }

                //MedicoBLL.Current.Update(medico);


            }
            MessageBox.Show("Medico modificado con éxito!");
        }
    }
}
