using BLL.Business;
using Domain;
using BLL.Dto;
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

namespace UI.Recepcionista
{
    public partial class NuevaObraSocial : Form
    {
        public NuevaObraSocial()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //var usser = ObraSocialBLL.Current.GetAll().Where(x => x.Nombre.Contains(txtNuevaOS.Text));

            string nuevaOS =txtNuevaOS.Text;

            var busqueda=Existe( nuevaOS);
            if (busqueda==true)
            {
                MessageBox.Show("Obra Social ya existe");
            }
            else if(busqueda==false)
            {
                var OS = new ObraSocialDto()
                {
                    Nombre = nuevaOS,

                };
                ObraSocialBLL.Current.Insert(OS);
                MessageBox.Show("Obra Social insertada con éxito!");
            }

           
        }

        private void NuevaObraSocial_Load(object sender, EventArgs e)
        {            
            

        }

        public bool Existe(string obrasocial)
        {
            var busqueda=ObraSocialBLL.Current.GetAll().FirstOrDefault(x => x.Nombre == obrasocial);
            if (busqueda!=null)
            {
                //busqueda.Nombre = txtNuevaOS.Text;
                return true;
            }
            return false;
        }
    }
}
