using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.EF6;
using BLL;
using DOMAIN;

namespace UI.Mapper
{
    public class MapperConfig
    {
   
        //#region Singleton
        //private readonly static MapperConfig _instance = new MapperConfig();

        //public static MapperConfig Current
        //{
        //    get
        //    {
        //        return _instance;
        //    }
        //}

        //public MapperConfig()
        //{
            
        //}
        //#endregion

        public static MapperConfiguration MapprConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Paciente, PacienteBLL>();
                cfg.CreateMap<PacienteBLL, Paciente>();
            });
        }
        public static void MapperConfiguration2()
        {
            var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<Paciente, PacienteBLL>());



           // var map = new MapperConfiguration(config);



        }

        
        
    }



}
