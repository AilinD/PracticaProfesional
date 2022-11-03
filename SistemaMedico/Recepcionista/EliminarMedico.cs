﻿using BLL.Business;
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
    public partial class EliminarMedico : Form
    {
        public EliminarMedico()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMedicoAEliminar.Text))
            {
                var user = MedicoBLL.Current.GetAll();
                dataGridView1.DataSource = user;
            }
            else
            {
                var usser = MedicoBLL.Current.GetAll().Where(x => x.Apellido.Contains(txtMedicoAEliminar.Text));
                dataGridView1.DataSource = usser.ToList();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var medico = new MedicoDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {

                medico.Id = (int)r.Cells["Id"].Value;
                medico.Matricula = (int)r.Cells["Matricula"].Value;
                medico.Nombre = r.Cells["Nombre"].Value.ToString();
                medico.Apellido = r.Cells["Apellido"].Value.ToString();
                medico.Direccion = r.Cells["Direccion"].Value.ToString();
                medico.Contacto = r.Cells["Contacto"].Value.ToString();
                MedicoBLL.Current.Delete(medico.Id);


            }
            MessageBox.Show("Medico Eliminado con éxito!");
        }
    }
}