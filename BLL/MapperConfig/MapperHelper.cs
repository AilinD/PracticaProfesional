using AutoMapper;
using DAL.Models;
using BLL.Dto;
using Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{ 
    public static class MapperHelper
    {
        readonly private static IMapper _mapper;
         static  MapperHelper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Paciente, PacienteDto>();
                cfg.CreateMap<PacienteDto, Paciente>();
                cfg.CreateMap<Medico, MedicoDto>();
                cfg.CreateMap<MedicoDto, Medico>();
                cfg.CreateMap<EstudioDto, Estudio>();
                cfg.CreateMap<Estudio, EstudioDto>();
                cfg.CreateMap<Sintoma, SintomaDto>();
                cfg.CreateMap<SintomaDto, Sintoma>();
                cfg.CreateMap<Especialidad, EspecialidadDto>();
                cfg.CreateMap<EspecialidadDto, Especialidad>();
                cfg.CreateMap<ObraSocial, ObraSocialDto>();
                cfg.CreateMap<ObraSocialDto, ObraSocial>();
            });

            _mapper = config.CreateMapper();
  
        }

        public static IMapper GetMapper()
        {
            return _mapper;
        }

    }
}
