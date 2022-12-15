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
    /// <summary>
    /// Clase que contiene las configraciones del AutoMapper para poder mapear los objetos locales con los necesarios para la base
    /// </summary>
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
                cfg.CreateMap<Diagnostico,DiagnosticoDto>();
                cfg.CreateMap<DiagnosticoDto, Diagnostico>();
                cfg.CreateMap<ObraSocialPaciente, ObraSocialPacienteDto>();
                cfg.CreateMap<ObraSocialPacienteDto, ObraSocialPaciente>();
                cfg.CreateMap<MedicoPorEspecialidad, MedicoPorEspecialidadDto>();
                cfg.CreateMap<MedicoPorEspecialidadDto, MedicoPorEspecialidad>();
                cfg.CreateMap<EstudioPaciente, EstudioPacienteDto>();
                cfg.CreateMap<EstudioPacienteDto, EstudioPaciente>();
                cfg.CreateMap<SintomaPaciente, SintomaPacienteDto>();
                cfg.CreateMap<SintomaPacienteDto, SintomaPaciente>();
            });

            _mapper = config.CreateMapper();
  
        }

        /// <summary>
        /// Devuelve el mapper solicitado
        /// </summary>
        /// <returns></returns>
        public static IMapper GetMapper()
        {
            return _mapper;
        }

    }
}
