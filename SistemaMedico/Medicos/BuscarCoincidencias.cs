using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Medicos
{
    public partial class BuscarCoincidencias : Form
    {
        public BuscarCoincidencias()
        {
            InitializeComponent();
        }

        private void BuscarCoincidencias_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("", @"C:\\Program Files (x86)\\swipl\\bin");
        }
    }
}
