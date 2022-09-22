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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {

        }

        private void cboxpatente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            List<string> pruebapat = new List<string>() { "BusBUS", "Admin", "User" };
            cboxpatente.DataSource = pruebapat;

            
            cboxpatente.DisplayMember = "name";

            //cboxpatente.SelectionChanged += new SelectionChangedEventHandler(cboxpatente_SelectionChanged);
        }
    }
}
