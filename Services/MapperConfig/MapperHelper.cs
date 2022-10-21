using AutoMapper;
using DOMAIN;
using Services.BLL.Dto;
using Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MapperConfig
{
    public class MapperHelper:Profile
    {
         public MapperHelper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Paciente, PacienteDto>();
                cfg.CreateMap<PacienteDto,Paciente>();
            });
  
        }

    }
}
