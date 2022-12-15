﻿using BLL.Business;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Services.Service;
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
using DAL.Models;
using BLL.Dto;
using Services.BLL;
using System.Diagnostics.Tracing;
using Services.BLL.Exepciones;
using iText.IO.Font.Otf;

namespace SistemaMedico.Reportes
{
    public partial class EstudiosXPaciente : Form
    {
        public EstudiosXPaciente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {

                var estudiomedicoext = new EstudioPacienteExtendido();
                List<EstudioPacienteExtendido> estudioPacienteExtendidos = new List<EstudioPacienteExtendido>();
                int dni = Convert.ToInt32(txtDniPaciente.Text);

                var paciente = PacienteBll.Current.GetAll().FirstOrDefault(x=>x.DNI==dni);
    
                var search = BLL.Business.EstudioPacienteBLL.Current.GetAll().Where(x => x.IdPaciente==paciente.IdPaciente);

               
                foreach (var item in search)
                {
                    var medico = BLL.Business.MedicoBLL.Current.GetAll().FirstOrDefault(x => x.IdMedico == item.IdMedico);

                    estudiomedicoext.Comentarios = item.Comentarios;
                    estudiomedicoext.FullnameMedico = String.Concat(medico.Nombre + " " + medico.Apellido);
                    estudiomedicoext.FullnamePaciente = String.Concat(paciente.Nombre + " " + paciente.Apellido);
                    estudiomedicoext.Fecha = item.Fecha;
                    estudiomedicoext.Estudio = EstudioBLL.Current.GetAll().FirstOrDefault(x => x.Id == item.IdEstudio).Nombre;
                    estudioPacienteExtendidos.Add(estudiomedicoext);
                }



                    

                dataGridView1.DataSource = estudioPacienteExtendidos.ToList();


                //var search = BLL.Business.EstudioPacienteBLL.Current.GetAll().Where(x => x.IdMedico == medico.IdMedico);

                //dataGridView1.Translate();
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }


        }

        private void EstudiosXPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                lblDNI.Translate();
                btnBuscar.Translate();
                btnGenerar.Translate();
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
            txtDniPaciente.Clear();
            dataGridView1.DataSource = null;

        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            try
            {

                string path = ConfigurationManager.AppSettings["ReportesPath"].ToString();
                if (dataGridView1.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = path;
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.InnerException.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dataGridView1.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("Reporte Generado!");
                                Limpiar();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.InnerException.Message);
                            }
                            Limpiar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay informacion para realizar el reporte");
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
        }
    }
}
