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

namespace SistemaMedico.Medicos
{
    public partial class HistorialPaciente : Form
    {
        public HistorialPaciente()
        {
            InitializeComponent();
        }

        private void HistorialPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDniPaciente.Text))
            {
              

                MessageBox.Show("Ingrese DNI paciente por favor");
            }
            else
            {
                int DNI = int.Parse(txtDniPaciente.Text);
                var busqueda = PacienteBll.Current.GetAll().FirstOrDefault(x => x.DNI == DNI);

                var usser = DiagnosticoBLL.Current.GetAll().Where(x => x.IdPaciente == busqueda.IdPaciente);
                gridDiagnostico.DataSource = usser.ToList();

            }
            
        }
    }
}
