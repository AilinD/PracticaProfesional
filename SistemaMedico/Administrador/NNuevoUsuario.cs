﻿
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.BLL.PatenteBLL;
using System.Configuration;
using Services.Domain;
using SistemaMedico.Extensions;
using Services;

namespace UI.Administrador
{
    public partial class NNuevoUsuario : Form
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
        public NNuevoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(txtContra2.Text))
            {
                var key = ConfigurationManager.AppSettings.Get("key");
                Usuario usuario = new Usuario();
                Familia familia = new Familia();
                familia.Nombre = cboxPatentes.SelectedItem.ToString();
                usuario.Nombre = txtNombre.Text;
                usuario.Password = Hashing.EncryptString(key, txtContraseña.Text);



                _instance.Nombre = Convert.ToString(cboxPatentes.SelectedItem);
                PatenteBLL.Insert(_instance);
                familia.Add(_instance);
                BLLFamilia.Insert(familia);

                usuario.Permisos.Add(_instance);
                usuario.Permisos.Add(familia);
                BLLUsuario.Insert(usuario);
                Limpiar();
                

            }
        }

        private void NNuevoUsuario_Load(object sender, EventArgs e)
        {
            // Set to no text.
            //txtPassword.Text = "";
            // The password character is an asterisk.
            txtContraseña.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtContraseña.MaxLength = 14;
            txtContraseña.UseSystemPasswordChar = true;

            txtContra2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtContra2.MaxLength = 14;
            txtContra2.UseSystemPasswordChar = true;


            List<string> permisos = new List<string>();
            permisos.Add("administrador");
            permisos.Add("Medico");
            permisos.Add("Recepcionista");
            cboxPatentes.DataSource =  permisos;
            cboxPatentes.DisplayMember = "Value";

            btnGuardar.Translate();
            lblNombre.Translate();
            lblPass.Translate();
            lblRepitePass.Translate();
            lblSelecPat.Translate();
            

        }

        private void cboxPatentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtContra2.Text = "";
            txtContraseña.Text = "";
            txtNombre.Text = "";
        }

        public void traduccion()
        {
            //Controls.OfType<Button>().Cast<Control>().ToList().ForEach(o => o.Text = o.Text.Translate());
            //foreach (DataGridView dgv in Controls.OfType<DataGridView>().Cast<DataGridView>().ToList())
            //{
            //    foreach (DataGridViewColumn column in dgv.Columns)
            //    {
            //        column.HeaderText = column.HeaderText.Translate();
            //    }
            //}
        }
    }
}

