using Services.Domain;
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
    public partial class ModificarPatentes : Form
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
        public ModificarPatentes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevaPatente nuevaPatente = new NuevaPatente();
            nuevaPatente.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNombrePatente.Text != "")
            {

                DataTable dt = new DataTable();
                var user = PatenteBLL.Select(txtNombrePatente.Text);
                dt.Columns.Add("IdPatente", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Rows.Add(user["IdPatente"], user["Nombre"]);
                dataGridView1.DataSource = dt;
                //dataGridView1.Translate();
            }


            else
            {
                dataGridView1.DataSource = BLLUsuario.SelectAll();
                //dataGridView1.Translate();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombrePatente.Text))
            {

                DataTable dt = new DataTable();
                var user = PatenteBLL.Select(txtNombrePatente.Text);
                dt.Columns.Add("IdPatente", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Rows.Add(user["IdPatente"], user["Nombre"]);
                dataGridView1.DataSource = dt;
                //dataGridView1.Translate();

            }


            else
            {
                dataGridView1.DataSource = PatenteBLL.SelectAll();
            }
        }

        private void btnModificarUS_Click(object sender, EventArgs e)
        {
            var patente = new Patente();
            patente.Nombre = txtNuevaPatente.Text;
            Guid guid = Guid.Parse(dataGridView1.SelectedRows[0].Cells["IdPatente"].Value.ToString());
            patente.IdFamiliaElement = guid.ToString();
            //ServiceLayer.BLL.PatenteBLL.Select(guid.ToString());

            PatenteBLL.Update(patente);

            MessageBox.Show("Patente modificada");
            Limpiar();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModificarPatentes_Load(object sender, EventArgs e)
        {
            btnBuscar.Translate();
            btnModificar.Translate();
            lblNuevoNombre.Translate();
            lblpatente.Translate();
            lblNuevoNombre.Translate();
        }
        private void Limpiar()
        {
            txtNombrePatente.Text = "";
            txtNuevaPatente.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
