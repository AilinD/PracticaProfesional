using BLL.Dto;
using BLL.MapperConfig;
using DAL;
using DAL.Models;
using iText.Kernel.Pdf;
using Microsoft.EntityFrameworkCore;
using Services;
using Services.BLL.Exepciones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{
    public class EstudioPacienteBLL
    {

        private readonly SysCExpertContext _context;

        #region Singleton
        private readonly static EstudioPacienteBLL _instance = new EstudioPacienteBLL();

        public static EstudioPacienteBLL Current
        {
            get
            {
                return _instance;
            }
        }

       
        #endregion


        public EstudioPacienteBLL()
        {
            _context=new SysCExpertContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        }


        public void InsertEstudioPaciente(EstudioPaciente estudioPaciente)
        {
            try
            {
                _context.EstudioPacientes.Add(estudioPaciente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                throw;
            }
            
        }       

        public IQueryable< EstudioPaciente> SelectPaciente(int id)
        {
                    
        var busqueda=
       (from ep in _context.EstudioPacientes
        join a in _context.Pacientes on ep.IdPaciente equals a.IdPaciente
        join e in _context.Estudios on ep.IdEstudio equals e.Id
        where a.Dni == id
        select new EstudioPaciente
        {
            Id=ep.Id,
            IdEstudio = ep.IdEstudio,
            Comentarios = ep.Comentarios,
            IdMedico = ep.IdMedico,
            IdPaciente = ep.IdPaciente,
            Fecha = ep.Fecha
        }); 

            return busqueda;

        }

        public IQueryable<EstudioPaciente> SelectMedico(int id)
        {

            var busqueda =
           (from ep in _context.EstudioPacientes
            join a in _context.Medicos on ep.IdMedico equals a.IdMedico
            join e in _context.Estudios on ep.IdEstudio equals e.Id
            where a.IdMedico == id
            select new EstudioPaciente
            {
                Id = ep.Id,
                IdEstudio = ep.IdEstudio,
                Comentarios = ep.Comentarios,
                IdMedico = ep.IdMedico,
                IdPaciente = ep.IdPaciente,
                Fecha = ep.Fecha
            });

            return busqueda;

        }

    }
}
