using BLL.Business;
using BLL.Dto;
using SistemaMedico.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico.Medicos
{
    public partial class SintomasPaciente : Form
    {
        public SintomasPaciente()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //var sintomasPaciente = new SintomasPacienteDto()
            //{
            //    //Fecha=DateTime.Now,
            //    //IdMedico=
            //    //Fecha = DateTime.Now,
            //    //IdMedico = obj.IdMedico,
            //    //diagnostico = obj.diagnostico,
            //    //IdPaciente = obj.IdPaciente
            //};
            //DiagnosticoBLL.Current.Insert(diagnostico);
           

            Limpiar();
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombrePaciente.Text))
            {
                var user = PacienteBll.Current.GetAll();
                dataGridView1.DataSource = user;
            }
            else
            {
                var usser = PacienteBll.Current.GetAll().Where(x => x.Apellido.Contains(txtNombrePaciente.Text));
                //dataGridView1.DataSource = usser;
                dataGridView1.DataSource = usser.ToList();
            }
        }

        private void Limpiar()
        {
            txtNombrePaciente.Text = "";
           dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
        }

        private void SintomasPaciente_Load(object sender, EventArgs e)
        {
            lblApellidoPaciente.Translate();
            lblSintomas.Translate();
            btnAgregar.Translate();
            btnBusca.Translate();
            btnBuscar.Translate();
            btnEliminar.Translate();
            btnModificar.Translate();
        }
    }
}
