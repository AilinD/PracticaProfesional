using AutoMapper;
using AutoMapper.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapper
{
    public static class MapperHelper
    {
        private readonly static IMapper _mapper;

         static MapperHelper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DOMAIN.Paciente,DataAccess.BaseProd.Paciente>();
                cfg.CreateMap<DataAccess.BaseProd.Paciente, DOMAIN.Paciente>();
            });
            _mapper = config.CreateMapper();
        }

        public static IMapper GetMapper()
        {
            return _mapper;
        }
        
    }
}
