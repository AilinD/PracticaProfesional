using BLL.Business;
using BLL.Dto;
using Services.BLL;
using SistemaMedico.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
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
            try
            {
                string nuevoEstudio = txtNuevoestudio.Text;


                var busqueda = Existe(nuevoEstudio);
                if (busqueda == true)
                {
                    MessageBox.Show("Estudio ya existe");
                }
                else if (busqueda == false)
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
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }

        }

        public bool Existe(string estudio)
        {
            try
            {
                var busqueda = EstudioBLL.Current.GetAll().FirstOrDefault(x => x.Nombre == estudio);
                if (busqueda != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
                return false;
            }
            
        }

        private void NuevoEstudio_Load(object sender, EventArgs e)
        {
            try
            {

                lblEstudio.Translate();
                btnAgregar.Translate();
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }
    }


}
