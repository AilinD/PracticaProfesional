using BLL.Business;
using Domain;
using Services.BLL.Dto;
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
            string nuevaOS=txtNuevaOS.Text;

            var OS = new ObraSocialDto()
            {
                Nombre = nuevaOS,

            };
            //ObraSocialBLL.Current.Insert(OS);
            MessageBox.Show("Obra Social insertada con éxito!");
        }
    }
}
