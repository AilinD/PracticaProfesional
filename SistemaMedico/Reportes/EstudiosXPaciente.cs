using BLL.Business;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico.Reportes
{
    public partial class EstudiosXPaciente : Form
    {
        public EstudiosXPaciente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var estudiosPac = new EstudioPaciente()
            {

            };
            //var estudioPaciente = new EstudioPaciente();
            //foreach (DataGridViewRow r in gridmedico.SelectedRows)
            //{
            //    estudioPaciente.IdMedico = (int)r.Cells["IdMedico"].Value;
            //    estudioPaciente.IdPaciente = idpaciente;
            //    estudioPaciente.IdEstudio = cbocestudio.SelectedIndex;
            //    estudioPaciente.Fecha = DateTime.Now;
            //    estudioPaciente.Comentarios = txtComentarios.Text;
            //}

            //EstudioPacienteBLL.Current.
        }
    }
}
