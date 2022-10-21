using AutoMapper;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
        public static ServiceProvider AddServices(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperHelper());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSingleton<IServiceCollection>(services);
            services.AddDbContext<SysEntitiesContext>(options => options.UseSqlServer("PatenteFamilia"));
            services.AddDbContext<SysEntitiesContext>(options => options.UseSqlServer("SysCExpert"));

            return services.BuildServiceProvider();
        }
    }
}
