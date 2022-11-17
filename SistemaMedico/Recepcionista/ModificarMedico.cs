﻿using BLL.Business;
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
                var user = MedicoBLL.Current.GetAll();
                dataGridView1.DataSource = user;
                dataGridView1.Translate();
            }
            else
            {
                var usser = MedicoBLL.Current.GetAll().Where(x => x.Apellido.Contains(txtApellidoMedico.Text));
                dataGridView1.DataSource = usser;
                dataGridView1.DataSource = usser.ToList();
                dataGridView1.Translate();
            }
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {

            var medico = new MedicoDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                medico.IdMedico = (int)r.Cells["IdMedico"].Value;
                medico.Matricula = (int)r.Cells["Matricula"].Value;
                medico.Nombre = r.Cells["Nombre"].Value.ToString();
                medico.Apellido = r.Cells["Apellido"].Value.ToString();
                
                if (string.IsNullOrEmpty(txtNuevoDomicilio.Text))
                {

                    medico.Direccion = r.Cells["Direccion"].Value.ToString();
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

                MedicoBLL.Current.Update(medico);


            }
            MessageBox.Show("Medico modificado con éxito!");
            Limpiar();
        }
        private void Limpiar()
        {
            txtApellidoMedico.Text = "";
            txtNuevoContacto.Text = "";
            txtNuevoDomicilio.Text = "";
            dataGridView1.DataSource = null;
        }

        private void ModificarMedico_Load(object sender, EventArgs e)
        {
            lblApellidoMedico.Translate();
            lblNuevoContacto.Translate();
            lblNuevoDomicilio.Translate();
            btnBuscar.Translate();
            btnModificar.Translate();
            dataGridView1.DataSource = null;
        }
    }
}
