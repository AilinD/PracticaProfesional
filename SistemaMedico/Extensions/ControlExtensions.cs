using Services.Service;
using SistemaMedico.Medicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace SistemaMedico.Extensions
{
    /// <summary>
    /// Clase de extension que le agrega el metodo de tranbslate al objeto que lo invoca
    /// </summary>
    public static class ControlExtensions
    {
        public static void Translate(this Control e)
        {
            e.Text = LanguageService.Translate(e.Name);
        }

        public static void Translate(this ToolStripMenuItem e)
        {
            e.Text= LanguageService.Translate(e.Name);
        }
    }
}
