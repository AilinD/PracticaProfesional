//using Domain;
using Services;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.MapperConfig;
using DAL.Factory;
using DAL.Models;
using BLL.Dto;
using Services.BLL.Exepciones;
//using DAL.Models;

namespace BLL.Business
{
    public  class ObraSocialBLL : IGenericBusiness<ObraSocialDto>
    {
        private readonly static ObraSocialBLL _instance = new ObraSocialBLL();


        public static ObraSocialBLL Current
        {
            get
            {
                return _instance;
            }
        }


        IGenericRepository<ObraSocial> genericRepository = FactoryDAL._obraSocialRepository;

        public void Insert(ObraSocialDto obj)
        {
            try
            {
                var dtoToentity = new ObraSocial()
                {
                    Id = obj.Id,
                    Nombre = obj.Nombre,


                };
                genericRepository.Insert(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                throw;
            }
            
        }

        public void Update(ObraSocialDto obj)
        {
            try
            {
                var dtoToentity = new ObraSocial()
                {
                    Id = obj.Id,
                    Nombre = obj.Nombre,


                };
                genericRepository.Update(dtoToentity);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                throw;
            }
            
        }

        public IEnumerable<ObraSocialDto> GetAll()
        {
            try
            {
                var entity = MapperHelper.GetMapper().
            Map<List<ObraSocialDto>>(genericRepository.GetAll());

                return entity;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                throw;
            }
            
        }

        public ObraSocialDto GetOne(int? guid)
        {
            try
            {
                var op = MapperHelper.GetMapper().Map<ObraSocialDto>(genericRepository.GetOne(guid));

                return op;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                throw;
            }
            
        }

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
    }
}
