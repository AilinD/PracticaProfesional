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
using Services.BLL.Exepciones;

namespace UI.Administrador
{
    public partial class ModificarPatentes : Form
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
        public ModificarPatentes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                NuevaPatente nuevaPatente = new NuevaPatente();
                nuevaPatente.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNombrePatente.Text != "")
                {

                    DataTable dt = new DataTable();
                    var user = PatenteBLL.Select(txtNombrePatente.Text);
                    dt.Columns.Add("IdPatente", typeof(string));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Rows.Add(user["IdPatente"], user["Nombre"]);
                    dataGridView1.DataSource = dt;
                    //dataGridView1.Translate();
                }


                else
                {
                    dataGridView1.DataSource = BLLUsuario.SelectAll();
                    //dataGridView1.Translate();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtNombrePatente.Text))
                {

                    DataTable dt = new DataTable();
                    var user = PatenteBLL.Select(txtNombrePatente.Text);
                    dt.Columns.Add("IdPatente", typeof(string));
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Rows.Add(user["IdPatente"], user["Nombre"]);
                    dataGridView1.DataSource = dt;
                    //dataGridView1.Translate();

                }


                else
                {
                    dataGridView1.DataSource = PatenteBLL.SelectAll();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
        }

        private void btnModificarUS_Click(object sender, EventArgs e)
        {
            try
            {
                var patente = new Patente();
                patente.Nombre = txtNuevaPatente.Text;
                Guid guid = Guid.Parse(dataGridView1.SelectedRows[0].Cells["IdPatente"].Value.ToString());
                patente.IdFamiliaElement = guid.ToString();
                //ServiceLayer.BLL.PatenteBLL.Select(guid.ToString());

                PatenteBLL.Update(patente);

                MessageBox.Show("Patente modificada");
                Limpiar();
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModificarPatentes_Load(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.Translate();
                btnModificar.Translate();
                lblNuevoNombre.Translate();
                lblpatente.Translate();
                lblNuevoNombre.Translate();
                tamanio();
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
        }
        private void tamanio()
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
        }
        private void Limpiar()
        {
            txtNombrePatente.Text = "";
            txtNuevaPatente.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
