using BLL.Business;
using BLL.Dto;
using SistemaMedico.Extensions;
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
    public partial class EliminarEstudio : Form
    {
        public EliminarEstudio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEstudioaEliminar.Text))
            {
                var user = EstudioBLL.Current.GetAll();
                dataGridView1.DataSource = user;
            }
            else
            {
                var usser = EstudioBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtEstudioaEliminar.Text));
                dataGridView1.DataSource = usser.ToList();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var estudio = new EstudioDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                estudio.Id = (int)r.Cells["Id"].Value;
                estudio.Nombre = r.Cells["Nombre"].Value.ToString();


                EstudioBLL.Current.Delete(estudio.Id);


            }
            MessageBox.Show("Estudio eliminado con éxito!");
            Limpiar();
        }

        private void EliminarEstudio_Load(object sender, EventArgs e)
        {
            lblEstudio.Translate();
            btnBuscar.Translate();
            btnEliminar.Translate();
        }

        private void Limpiar()
        {
            txtEstudioaEliminar.Text = "";
           dataGridView1.DataSource = null;
        }
    }
}
