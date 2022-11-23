using BLL.Business;
using BLL.Dto;
using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.BLL.PatenteBLL;
using Services.Domain;
using Services;
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
using System.Configuration;
using Domain;

namespace SistemaMedico.Recepcionista
{
    public partial class NuevoMedico : Form
    {
        private readonly static Patente _instance = new Patente();
        private  static int _IdMedico;
        public NuevoMedico()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int Matricula = int.Parse(txtMatricula.Text);
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            string Domicilio = txtDomicilio.Text;
            string Contacto = txtContacto.Text;

            var busqueda = Existe(Matricula);
            if (busqueda == true)
            {
                MessageBox.Show("Medico ya existe");
            }else if (busqueda==false)
            {
                var medico = new MedicoDto()
                {
                    Matricula = Matricula,
                    Apellido = Apellido,
                    Nombre = Nombre,
                    Direccion = Domicilio,
                    Contacto = Contacto


                };
                MedicoBLL.Current.Insert(medico);
                _IdMedico = Matricula;
                var medicoEspecialista = new MedicoPorEspecialidad();
                {
                    var Search = MedicoBLL.Current.GetAll().FirstOrDefault(x => x.Apellido.Contains(txtApellido.Text));
                    cboxEspecialidad_SelectedIndexChanged(sender, e);
                    medicoEspecialista.IdEspecialidad = cboxEspecialidad.SelectedIndex;
                    medicoEspecialista.IdMedico = Search.IdMedico;
                }

                MedicoEspecialidadBLL.Current.InsertEspecialidadMedico(medicoEspecialista);
                InsertarUsuarioMedico();
                MessageBox.Show("Medico insertado con éxito!");
                txtApellido.Text = "";
                txtContacto.Text = "";
                txtMatricula.Text = "";
                txtNombre.Text = "";
                txtDomicilio.Text = "";
            }
               
        }

        private void NuevoMedico_Load(object sender, EventArgs e)
        {
            cboxEspecialidad.DataSource = EspecialidadBLL.Current.GetAll().ToList();
            cboxEspecialidad.DisplayMember = "Nombre";
            cboxEspecialidad.ValueMember = "Id";
            lblApellido.Translate();
            lblContacto.Translate();
            lblDomicilio.Translate();
            lblEspecialidad.Translate();
            lblMatricula.Translate();
            lblNombre.Translate();
            btnAgregar.Translate();
            
        }

        public void InsertarUsuarioMedico()
        {
            var key = ConfigurationManager.AppSettings.Get("key");
            Usuario usuario = new Usuario();
            Familia familia = new Familia();
            familia.Nombre = "Medico";
            usuario.Nombre = txtNombre.Text+txtApellido.Text;
            usuario.Password = Hashing.EncryptString(key, txtNombre.Text);
            usuario.IdUsuario = Guid.NewGuid().ToString();
            

            var busqueda = MedicoBLL.Current.GetAll().FirstOrDefault(x => x.IdMedico == _IdMedico);
            usuario.IdRol = busqueda.Matricula;

            _instance.Nombre = familia.Nombre;
            PatenteBLL.Insert(_instance);
            familia.Add(_instance);
            BLLFamilia.Insert(familia);

            usuario.Permisos.Add(_instance);
            usuario.Permisos.Add(familia);
            BLLUsuario.Insert(usuario);
        }

        private void cboxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public bool Existe(int Mmedico)
        {
            var busqueda = MedicoBLL.Current.GetAll().FirstOrDefault(x => x.Matricula == Mmedico);
            if (busqueda != null)
            {
                return true;
            }
            return false;
        }
    }
}
