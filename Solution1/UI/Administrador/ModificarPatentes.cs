using ServiceLayer.BLL;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            }


            else
            {
                dataGridView1.DataSource = BLLUsuario.SelectAll();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtNombrePatente.Text != "")
            {

                DataTable dt = new DataTable();
                var user = PatenteBLL.Select(txtNombrePatente.Text);
                dt.Columns.Add("IdPatente", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Rows.Add(user["IdPatente"], user["Nombre"]);
                dataGridView1.DataSource = dt;

            }


            else
            {
                dataGridView1.DataSource = PatenteBLL.SelectAll();
            }
        }

        private void btnModificarUS_Click(object sender, EventArgs e)
        {
            var patente = new ServiceLayer.Domain.PatenteFamilia.Patente();
            patente.Nombre = txtNuevaPatente.Text;
            Guid guid = Guid.Parse(dataGridView1.SelectedRows[0].Cells["IdPatente"].Value.ToString());
            patente.IdFamiliaElement = guid.ToString();
            //ServiceLayer.BLL.PatenteBLL.Select(guid.ToString());

            PatenteBLL.Update(patente);

            MessageBox.Show("Patente modificada");
            
        }
    }
}
