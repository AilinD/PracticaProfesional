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
    public partial class NuevaPatente : Form
    {
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
            familia.Add("administrador");
            familia.Add("medicos");
            familia.Add("usuario");
            cboxFamiliaPatente.DataSource = familia;
            cboxFamiliaPatente.DisplayMember = "Value";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            PatenteBLL.Insert();
        }
    }
}
