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
    public partial class EliminarObraSocial : Form
    {
        public EliminarObraSocial()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOSaEliminar.Text))
            {
                var user = ObraSocialBLL.Current.GetAll();
                dataGridView1.DataSource = user;
            }
            else
            {
                var usser = ObraSocialBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtOSaEliminar.Text));
                dataGridView1.DataSource = usser.ToList();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var obrasocial = new ObraSocialDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                obrasocial.Id = (int)r.Cells["Id"].Value;
                obrasocial.Nombre = r.Cells["Nombre"].Value.ToString();


                ObraSocialBLL.Current.Delete(obrasocial.Id);


            }
            MessageBox.Show("Obra Social eliminada con éxito!");
            Limpiar();
        }
        private void Limpiar()
        {
            txtOSaEliminar.Text = "";
            dataGridView1.ClearSelection();
        }

        private void EliminarObraSocial_Load(object sender, EventArgs e)
        {
            lblObraSocial.Translate();
            btnBuscar.Translate();
            btnEliminar.Translate();
        }
    }
}
