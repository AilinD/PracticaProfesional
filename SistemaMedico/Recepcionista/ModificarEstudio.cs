using BLL.Business;
using BLL.Dto;
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
    public partial class ModificarEstudio : Form
    {
        public ModificarEstudio()
        {
            InitializeComponent();
        }

        private void btnBuscaEstudio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEstudio.Text))
            {
                var user = EstudioBLL.Current.GetAll();
                dataGridView1.DataSource = user;
            }
            else
            {
                var usser = EstudioBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtEstudio.Text));
                dataGridView1.DataSource = usser.ToList();
            }
        }

        private void btnModificarEstudio_Click(object sender, EventArgs e)
        {
            var estudio = new EstudioDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                estudio.Id = (int)r.Cells["Id"].Value;
                estudio.Nombre = txtNuevoNombre.Text;


                EstudioBLL.Current.Update(estudio);


            }
            MessageBox.Show("Estudio modificado con éxito!");
        }
    }
}
