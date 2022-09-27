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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormContBackRest formBackRest = new FormContBackRest();
            formBackRest.ShowDialog();
            formBackRest.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPatenteFamilia formPatenteFam = new  FormPatenteFamilia();
            formPatenteFam.ShowDialog();
            formPatenteFam.Hide();
        }
    }
}
