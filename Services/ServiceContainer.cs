using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceContainer
    {

        private static ServiceProvider _services { get; set; } = SetupServices();

        private ServiceContainer() { }

        private static ServiceProvider SetupServices()
        {



            var services = new ServiceCollection();
            //services.AddSingleton<P>();


            //services.AddDbContext<SysEntitiesContext>(options => options.UseSqlServer("PatenteFamilia"));
            services.AddDbContext<SysEntitiesContext>(options
                =>
            {
                options.UseSqlServer("Data Source=DESKTOP-H0P0HUN\\SQLEXPRESS;Initial Catalog=SysCExpert;Integrated Security=True");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
                
                                                    

            var service = services.BuildServiceProvider();

            return service;


        }

        public static ServiceProvider Instance
        {
            get
            {
                if (_services == null)
                    _services = SetupServices();



                return _services;
            }
        }
    }  
}
