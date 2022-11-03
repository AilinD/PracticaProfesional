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
    public partial class ModificarObraSocial : Form
    {
        public ModificarObraSocial()
        {
            InitializeComponent();
        }

        private void btnBuscaMedico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtObraSocial.Text))
            {
                var user = ObraSocialBLL.Current.GetAll();
                dataGridView1.DataSource = user;
            }
            else
            {
                var usser = ObraSocialBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtObraSocial.Text));
                dataGridView1.DataSource = usser.ToList();
            }
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {
            var obrasocial = new ObraSocialDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                obrasocial.Id = (int)r.Cells["Id"].Value;
                obrasocial.Nombre = txtNuevoNombre.Text;
              

                ObraSocialBLL.Current.Update(obrasocial);


            }
            MessageBox.Show("Obra Social modificada con éxito!");
        }
    }
}