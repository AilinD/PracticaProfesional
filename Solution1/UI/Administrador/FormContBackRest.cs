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
    public partial class FormContBackRest : Form
    {
        public FormContBackRest()
        {
            InitializeComponent();
        }

        private void btnOpcBackup_Click(object sender, EventArgs e)
        {
            FormularioBakup formularioBakup = new FormularioBakup();
            formularioBakup.ShowDialog();
            formularioBakup.Hide();
        }

        private void btnOpcRestore_Click(object sender, EventArgs e)
        {
            FormularioRestore formularioRestore = new FormularioRestore();
            formularioRestore.ShowDialog();
            formularioRestore.Hide();
        }

        private void FormContBackRest_Load(object sender, EventArgs e)
        {

        }
    }
}
