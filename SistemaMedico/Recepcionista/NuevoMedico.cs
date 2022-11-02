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
    public partial class NuevoMedico : Form
    {
        public NuevoMedico()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int Matricula = int.Parse(txtMatricula.Text);
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            string Domicilio = txtDomicilio.Text;
            string Contacto = txtContacto.Text;

            var medico = new MedicoDto()
            {
                Matricula = Matricula,
                Apellido = Apellido,
                Nombre = Nombre,
                Direccion = Domicilio,
                Contacto = Contacto


            };
            MedicoBLL.Current.Insert(medico);
            MessageBox.Show("Medico insertado con éxito!");
        }
    }
}
