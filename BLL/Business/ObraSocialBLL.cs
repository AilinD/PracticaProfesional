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
            var dtoToentity = new ObraSocial()
            {
                Id = obj.Id,
                Nombre = obj.Nombre,


            };
            genericRepository.Insert(dtoToentity);
        }

        public void Update(ObraSocialDto obj)
        {
            var dtoToentity = new ObraSocial()
            {
                Id = obj.Id,
                Nombre = obj.Nombre,


            };
            genericRepository.Update(dtoToentity);
        }

        public IEnumerable<ObraSocialDto> GetAll()
        {
            var entity = MapperHelper.GetMapper().
            Map<List<ObraSocialDto>>(genericRepository.GetAll());

            return entity;
        }

        public ObraSocialDto GetOne(int? guid)
        {
            var op = MapperHelper.GetMapper().Map<ObraSocialDto>(genericRepository.GetOne(guid));

            return op;
        }

        public void Delete(int? guid)
        {
            var op = genericRepository.GetOne(guid);
            if (op != null)
            {
                genericRepository.Delete(op);
            }
        }
    }
}
