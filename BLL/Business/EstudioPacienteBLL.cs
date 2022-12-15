using BLL.Dto;
using BLL.Interfaces;
using BLL.MapperConfig;
using DAL;
using DAL.Factory;
using DAL.Interfaces;
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
    /// <summary>
    /// Clase de negocio, a traves del UnitOfWork tiene los metodos necesarios para poder comunciarse con la capa de Datos
    /// </summary>
    public class EstudioPacienteBLL : IGenericBusiness<EstudioPacienteDto>
    {

        private static readonly SysCExpertContext _context;

        #region Singleton
        private readonly static EstudioPacienteBLL _instance = new EstudioPacienteBLL();

        public static EstudioPacienteBLL Current
        {
            get
            {
                return _instance;
                
            }
        }

        //public  EstudioPacienteBLL()
        //{
        //    _context = new SysCExpertContext(ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString);
        //}


        #endregion

        IGenericRepository<EstudioPaciente> genericRepository = FactoryDAL._estudioPacienteRepository;


        /// <summary>
        /// Inserta un registro en la tabla EstudioPaciente
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(EstudioPacienteDto obj)
        {
            try
            {
                var dtoToentity = new EstudioPaciente()
                {
                    IdEstudio = obj.IdEstudio,
                    IdMedico = obj.IdMedico,
                    Fecha = obj.Fecha,
                    Comentarios = obj.Comentarios,
                    IdPaciente = obj.IdPaciente

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);


            }
        }

        /// <summary>
        /// Actualiza un registro en la tabla EstudioPaciente
        /// </summary>
        /// <param name="obj"></param>
        public void Update(EstudioPacienteDto obj)
        {
            try
            {
                var dtoToentity = new EstudioPaciente()
                {
                    Id = obj.Id,
                    IdEstudio = obj.IdEstudio,
                    IdMedico = obj.IdMedico,
                    Fecha = obj.Fecha,
                    Comentarios = obj.Comentarios,


                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);


            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla EstudioPaciente
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EstudioPacienteDto> GetAll()
        {
            try
            {
                var entity = MapperHelper.GetMapper().
            Map<List<EstudioPacienteDto>>(genericRepository.GetAll());

                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
            return null;
        }

        /// <summary>
        /// Obtiene un registro de la tabla EstudioPaciente
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public EstudioPacienteDto GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<EstudioPacienteDto>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
            }
            return null;
        }

        /// <summary>
        /// Elimina un registro de la tabla EstudioPaciente
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(int? guid)
        {
            try
            {
                var op = genericRepository.GetOne(guid);
                if (op != null)
                {
                    genericRepository.Delete(op);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);


            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IQueryable<EstudioPaciente> SelectPaciente(int id)
        {

            var busqueda =
           (from ep in _context.EstudioPacientes
            join a in _context.Pacientes on ep.IdPaciente equals a.IdPaciente
            join e in _context.Estudios on ep.IdEstudio equals e.Id
            where a.Dni == id
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
