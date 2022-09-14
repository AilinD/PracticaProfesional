using Microsoft.SqlServer.Management.XEvent;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Administrador;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new FormularioRestore());
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
