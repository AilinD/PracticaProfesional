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
{
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

                throw;
            }
        }

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

                throw;
            }
        }

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

                throw;
            }
        }

        public void Insert(DiagnosticoDto obj)
        {
            try
            {
                var dtoToentity = new Diagnostico()
                {
                    Id = obj.Id,
                    Fecha=obj.Fecha,
                    IdMedico=obj.IdMedico,
                    Diagnostico1 = obj.diagnostico,
                    IdPaciente=obj.IdPaciente

                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                throw;
            }          
        }

        public void Update(DiagnosticoDto obj)
        {
            try
            {
                var dtoToentity = new Diagnostico()
                {
                    Id = obj.Id,
                    Fecha = obj.Fecha,
                    IdMedico = obj.IdMedico,
                    Diagnostico1 = obj.diagnostico,
                    IdPaciente = obj.IdPaciente

                }; 
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                throw;
            }
        }
    }
}
