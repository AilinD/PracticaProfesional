using AutoMapper;
using BLL;
using BLL.Interfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.BLL;
using Services.BLL.Dto;
using Services.Logger;
using Services.MapperConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico
{
    public static class ConfigureServices
    {
        public static ServiceProvider AddServices()
        {
            var services=new ServiceCollection();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperHelper());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSingleton<IServiceCollection>(services);
            services.AddSingleton<IGenericBusiness<PacienteDto>, PatientService>();
            services.AddDbContext<SysEntitiesContext>(options => options.UseSqlServer("PatenteFamilia"));
            services.AddDbContext<SysEntitiesContext>(options => options.UseSqlServer("SysCExpert"));

            services.AddSingleton<PatientRepository>();
            services.AddSingleton<PatientService>();
            services.AddSingleton<LoginService>();
            services.AddSingleton<LoggerService>();

            return services.BuildServiceProvider();
        }
    }
}
