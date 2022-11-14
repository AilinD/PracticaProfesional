﻿using Services.Domain;
using Services.BLL.PatenteBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMedico.Extensions;

namespace UI.Administrador
{
    public partial class NuevaPatente : Form
    {
        #region singleton
        private readonly static Patente _instance = new Patente();
        public static Patente Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        public NuevaPatente()
        {
            InitializeComponent();
        }

        private void txtFamiliaPatente_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevaPatente_Load(object sender, EventArgs e)
        {
            List<string> familia = new List<string>();
            familia.Add("Administrador");
            familia.Add("Medicos");
            familia.Add("Usuario");
            familia.Add("Recepcionista");
            familia.Add("Base Experta");
            cboxFamiliaPatente.DataSource = familia;
            cboxFamiliaPatente.DisplayMember = "Value";

            btnGuardar.Translate();
            lblFamiliaPatente.Translate();
            lblpatente.Translate();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // _instance.IdFamiliaElement = cboxFamiliaPatente.Text;
            _instance.Nombre = txtNombrePatente.Text;
            PatenteBLL.Insert(_instance);
            MessageBox.Show("Patente Insertada con exito");
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombrePatente.Text = "";
        }
    }
}
