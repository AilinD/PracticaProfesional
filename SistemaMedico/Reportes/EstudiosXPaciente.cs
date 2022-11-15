using BLL.Business;
using Services.Service;
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

namespace SistemaMedico.Reportes
{
    public partial class EstudiosXPaciente : Form
    {
        public EstudiosXPaciente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDniPaciente.Text);
            string nombreArch = string.Format("{0}",txtNombreArch.Text+".pdf");
            var search = BLL.Business.EstudioPacienteBLL.Current.Select(dni);
            EstudioPacienteBLL.Current.PdfMaker(search, nombreArch);
            //ReportesPath
            MessageBox.Show("Reporte generado");
            Limpiar();
        }

        private void EstudiosXPaciente_Load(object sender, EventArgs e)
        {
            lblDNI.Translate();
            btnGenerar.Translate();
        }

        private void Limpiar()
        {
            txtDniPaciente.Clear();
            txtNombreArch.Clear();
        }
    }
}
