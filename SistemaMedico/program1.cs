using BLL;
using BLL.Business;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Application.Run(new ModificaPaciente());
            //Application.Run(new NuevoPaciente());


            var services = new ServiceCollection();

            services.AddSingleton(x => ServiceContainer.Instance.GetService<PacienteBll>());

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            DependencyService.SetInstance(serviceProvider);



        }

    }
}
