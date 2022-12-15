using BLL;
using BLL.Business;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.BLL;
using Services.BLL.PatenteBLL;
using Services.Domain;
using SistemaMedico.Medicos;
using SistemaMedico.Recepcionista;
using SistemaMedico.Reportes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;
using UI.Administrador;
using UI.Generales;
using UI.Medicos;
using UI.Recepcionista;
//using Windows.Storage.Provider;
//using Windows.System.Diagnostics;

namespace SistemaMedico
{
    internal static  class program1
    {

        [STAThread]
        static void Main()
        {
            try
            {

            
            Application.EnableVisualStyles();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new MenuPrincipal(PromptForLogin));
                //getpar();
                Application.Run(new MenuPrincipal(PromptForLogin()));

                var services = new ServiceCollection();

            services.AddSingleton(x => ServiceContainer.Instance.GetService<PacienteBll>());

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            DependencyService.SetInstance(serviceProvider);
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("", EventLevel.Warning, "");
            }
        }

        public static void getpar()
        {
            PatenteBLL.GetAllAdapted();
            //PatenteBLL.GetAdapted();
        }

        public static Sesion PromptForLogin()
        {
            using (var loginForm = new Login())
            {
                var dialogResult = loginForm.ShowDialog();
                if (dialogResult == DialogResult.OK)

                    return loginForm.SesionIniciada;

                loginForm.Close();
            }
            return default;
        }
    }
}
