using ServiceLayer.BLL;
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
    public partial class EliminarPatente : Form
    {
        public EliminarPatente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPatenteAEliminar.Text != "")
            {
                DataTable dt = new DataTable();
                var pat = PatenteBLL.Select(txtPatenteAEliminar.Text);
                dt.Columns.Add("IdPatente", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Rows.Add(pat["IdPatente"], pat["Nombre"]);
                dataGridView1.DataSource = dt;

            }

           


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var patente = new ServiceLayer.Domain.PatenteFamilia.Patente();
            patente.Nombre = txtPatenteAEliminar.Text;
            Guid guid = Guid.Parse(dataGridView1.SelectedRows[0].Cells["IdPatente"].Value.ToString());
            patente.IdFamiliaElement = guid.ToString();
            //ServiceLayer.BLL.PatenteBLL.Select(guid.ToString());
            PatenteBLL.Delete(patente);
            MessageBox.Show("Patente eliminada");
        }
    }
}
