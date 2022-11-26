using Services.Domain;
using Services.BLL.PatenteBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMedico.Extensions;
using Services.BLL;
using System.Diagnostics.Tracing;

namespace UI.Administrador
{
    public partial class NuevaPatente : Form
    {
        #region singleton
        private readonly static Patente _instance = new Patente();
        public static Patente Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        public NuevaPatente()
        {
            InitializeComponent();
        }

        private void txtFamiliaPatente_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevaPatente_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> familia = new List<string>();
                familia.Add("Administrador");
                familia.Add("Medicos");
                familia.Add("Usuario");
                familia.Add("Recepcionista");
                //cboxFamiliaPatente.DataSource = familia;
                cboxFamiliaPatente.DisplayMember = "Value";
                cboxFamiliaPatente.Items.Add("Administrador");
                cboxFamiliaPatente.Items.Add("Medicos");
                cboxFamiliaPatente.Items.Add("Usuario");
                cboxFamiliaPatente.Items.Add("Recepcionista");
                btnGuardar.Translate();
                lblFamiliaPatente.Translate();
                lblpatente.Translate();
                cboxFamiliaPatente.Translate();
                tamanio();
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }
        private void tamanio()
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // _instance.IdFamiliaElement = cboxFamiliaPatente.Text;
                if (string.IsNullOrEmpty(txtNombrePatente.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre");
                    LoggerBLL.WriteLog("Error al crear nueva patente", EventLevel.Warning, txtNombrePatente.Text + "campo vacio");

                }
                else
                {
                    _instance.Nombre = txtNombrePatente.Text;
                    PatenteBLL.Insert(_instance);
                    MessageBox.Show("Patente Insertada con exito");

                }
                Limpiar();
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog(ex.Message, EventLevel.Warning, "");
            }
        }

        private void Limpiar()
        {
            txtNombrePatente.Text = "";
        }
    }
}
