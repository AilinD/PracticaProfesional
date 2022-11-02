using BLL;
using BLL.Business;
using Microsoft.Extensions.DependencyInjection;
using Services;
using SistemaMedico.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Medicos;
using UI.Recepcionista;

namespace SistemaMedico
{
    internal static  class program1
    {    
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EliminarMedico());
            //Application.Run(new NuevoPaciente());
            //Application.Run(new EliminarPaciente());
            //Application.Run(new BuscarCoincidencias());

            var services = new ServiceCollection();

            services.AddSingleton(x => ServiceContainer.Instance.GetService<PacienteBll>());

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            DependencyService.SetInstance(serviceProvider);



        }

    }
}
