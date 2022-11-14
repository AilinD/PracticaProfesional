using BLL.Dto;
using BLL.MapperConfig;
using DAL;
using DAL.Models;
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

        //public void EstudioPaciente(int idpaciente)
        //{
        //    var busqueda =_context.EstudioPacientes.FirstOrDefault().IdPaciente= idpaciente;
        //    var prueba = _context.EstudioPacientes.Select(x=>x.IdPaciente.Value)
            
        //}

        //public EstudioPaciente GetOne(int? guid)
        //{
        //    try
        //    {
        //        ////var op = MapperHelper.GetMapper().Map<EstudioPaciente>(_context.GetOne(guid));

        //        /* return op;*/
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionManager.Current.Handle(ex);

        //        throw;
        //    }

        //}

        public IQueryable< EstudioPaciente> select(int id)
        {
            var busqueda = (from a in _context.EstudioPacientes join p in _context.Pacientes on a.IdPaciente equals id join estudio in _context.Estudios on a.IdEstudio equals estudio.Id
                            where a.Id == id
                            select new EstudioPaciente { IdEstudio = a.IdEstudio,
                                Comentarios = a.Comentarios,
                                IdMedico = a.IdMedico,
                                IdPaciente = a.IdPaciente,
                                Fecha = a.Fecha });


            return busqueda;

        }

    }
}
