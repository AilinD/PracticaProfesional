using AutoMapper;
using Domain;
using Services.BLL.Dto;
using Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MapperConfig
{ 
    public static class MapperHelper
    {
        readonly private static IMapper _mapper;
         static  MapperHelper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Paciente, PacienteDto>();
                cfg.CreateMap<PacienteDto,Paciente>();
                cfg.CreateMap<Medico, MedicoDto>();
                cfg.CreateMap<MedicoDto, Medico>();
                cfg.CreateMap<EstudioDto, Estudio>();
                cfg.CreateMap<Estudio, EstudioDto>();
            });

            _mapper = config.CreateMapper();
  
        }

        public static IMapper GetMapper()
        {
            return _mapper;
        }

    }
}
