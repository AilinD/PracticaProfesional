using BLL.Business;
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
            }
            else
            {
                var usser = MedicoBLL.Current.GetAll().Where(x => x.Apellido.Contains(txtApellidoMedico.Text));
                //dataGridView1.DataSource = usser;
                dataGridView1.DataSource = usser.ToList();
            }
        }
    }
}
