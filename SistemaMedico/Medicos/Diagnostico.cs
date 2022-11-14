using Services.BLL.PatenteBLL;
using SistemaMedico.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico.Medicos
{
    public partial class Diagnostico : Form
    {
        public Diagnostico()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

        }

        private void Diagnostico_Load(object sender, EventArgs e)
        {
            //var isAuth = BLLUsuario.GetUsuarioByUserName();
            lblDiagnostico.Translate();
            lblDNI.Translate();
            btnBuscar.Translate();
            btnGuardar.Translate();
        }
    }
}
