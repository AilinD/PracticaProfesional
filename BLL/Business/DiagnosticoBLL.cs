using BLL.Business;
using BLL.Dto;
using BLL.Interfaces;
using BLL.MapperConfig;
using DAL.Factory;
using DAL.Interfaces;
using DAL.Models;
using Services.BLL.Exepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Business
{/// <summary>
/// Clase de negocio, a traves del UnitOfWork tiene los metodos necesarios para poder comunciarse con la capa de Datos
/// </summary>
    public class DiagnosticoBLL : IGenericBusiness<DiagnosticoDto>
    {

        private readonly static DiagnosticoBLL _instance = new DiagnosticoBLL();


        public static DiagnosticoBLL Current
        {
            get
            {
                return _instance;
            }
        }

        IGenericRepository<Diagnostico> genericRepository = FactoryDAL._diagnosticoRepository;


        /// <summary>
        /// Borra un registro de la base Diagnostico
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
        /// Obtiene todos los registros de la tabla Diagnostico
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DiagnosticoDto> GetAll()
        {
            try
            {
                List<DAL.Models.Diagnostico> listado = genericRepository.GetAll().ToList();
        
                var entity = MapperHelper.GetMapper().
            Map<List<Diagnostico>, List<DiagnosticoDto>>(genericRepository.GetAll().ToList());
                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;
        }

        /// <summary>
        /// Obtiene un solo registro de la base Diagnostico
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public DiagnosticoDto GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<DiagnosticoDto>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;
        }

        /// <summary>
        /// Inserta un registto en la base Diagnostico
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(DiagnosticoDto obj)
        {
            try
            {
                var dtoToentity = new Diagnostico()
                {
                    Id = obj.Id,
                    Fecha=obj.Fecha,
                    IdMedico=obj.IdMedico,
                    diagnostico = obj.diagnostico,
                    IdPaciente=obj.IdPaciente

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }          
        }

        /// <summary>
        /// Actuializa un registro de la tabla Diagnostico
        /// </summary>
        /// <param name="obj"></param>
        public void Update(DiagnosticoDto obj)
        {
            try
            {
                var dtoToentity = new Diagnostico()
                {
                    Id = obj.Id,
                    Fecha = obj.Fecha,
                    IdMedico = obj.IdMedico,
                    diagnostico = obj.diagnostico,
                    IdPaciente = obj.IdPaciente

                }; 
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }
    }
}
