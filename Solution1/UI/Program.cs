using AutoMapper;
using Microsoft.SqlServer.Management.XEvent;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Administrador;
using UI.Generales;
using UI.Mapper;
using UI.Recepcionista;

namespace UI
{
    internal static class Program
    {
        internal static MapperConfiguration mapperConfiguration { get; private set; }

        private static IMapper _mapper;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
           // InitializeAutomapper();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         //---  Application.Run(new MenuPrincipal(PromptForLogin()));
            Application.Run(new NuevoPaciente());

            


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

      public static void InitializeAutomapper()
        {
            
            mapperConfiguration.CreateMapper();
        }
     
        
        
    }
}
