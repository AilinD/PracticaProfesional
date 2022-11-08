using BLL.Business;
using BLL.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico.Recepcionista
{
    public partial class NuevoEstudio : Form
    {
        public NuevoEstudio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoEstudio = txtNuevoestudio.Text;


            var busqueda = Existe(nuevoEstudio);
            if (busqueda == true)
            {
                MessageBox.Show("Estudio ya existe");
            }else if(busqueda == false)
            {

                var estudio = new EstudioDto()
                {
                    Nombre = nuevoEstudio,

                };
                EstudioBLL.Current.Insert(estudio);
                MessageBox.Show("Estudio insertado con éxito!");

                txtNuevoestudio.Text = "";
            }

        }

        public bool Existe(string estudio)
        {
            var busqueda = EstudioBLL.Current.GetAll().FirstOrDefault(x => x.Nombre == estudio);
            if (busqueda != null)
            {
                return true;
            }
            return false;
        }
    }


}
