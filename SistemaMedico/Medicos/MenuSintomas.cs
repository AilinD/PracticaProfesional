using BLL.Business;
using BLL.Dto;
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
    public partial class MenuSintomas : Form
    {
        public MenuSintomas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nuevoSintoma = txtNuevoNombre.Text;


            var busqueda = Existe(nuevoSintoma);
            if (busqueda == true)
            {
                MessageBox.Show("Sintoma ya existe");
                Limpiar();
            }
            else if (busqueda == false)
            {

                var sintoma = new SintomaDto()
                {
                    Nombre = nuevoSintoma,

                };
                SintomaBLL.Current.Insert(sintoma);
                MessageBox.Show("Sintoma insertado con éxito!");

                Limpiar();
            }
        }
        public bool Existe(string sintoma)
        {
            var busqueda = SintomaBLL.Current.GetAll().FirstOrDefault(x => x.Nombre == sintoma);
            if (busqueda != null)
            {
                return true;
            }
            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsBuscarSintomas.Text))
            {
                var user = SintomaBLL.Current.GetAll();
                dataGridView1.DataSource = user;
            }
            else
            {
                var usser = SintomaBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtsBuscarSintomas.Text));
                dataGridView1.DataSource = usser.ToList();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var simtoma = new SintomaDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                simtoma.IdSintoma = (int)r.Cells["IdSintoma"].Value;
                simtoma.Nombre = r.Cells["Nombre"].Value.ToString();


                SintomaBLL.Current.Delete(simtoma.IdSintoma);


            }
            MessageBox.Show("Sintoma eliminado con éxito!");
            Limpiar();
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            var sintoma = new SintomaDto();

            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                sintoma.IdSintoma = (int)r.Cells["IdSintoma"].Value;
                sintoma.Nombre = txtNuevoNombre.Text;               
                

                SintomaBLL.Current.Update(sintoma);


            }
            MessageBox.Show("Sintoma modificado con éxito!");
            Limpiar();
        }

        private void Limpiar()
        {
            txtNuevoNombre.Text = "";
            txtsBuscarSintomas.Text = "";
            dataGridView1.ClearSelection();
        }

        private void MenuSintomas_Load(object sender, EventArgs e)
        {
            lblNuevoNombre.Translate();
            btnModificar.Translate();
            btnBuscar.Translate();
            btnAgregar.Translate();
            btnEliminar.Translate();
            lblSintomas.Translate();
        }
    }
}
