using Org.BouncyCastle.Asn1.Crmf;
using Services.Service;
using SistemaMedico.Medicos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization;
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

        public static void Translate(this ComboBox e)
        {
            
            var items = new List<string>();
            items.AddRange(e.Items.Cast<string>().ToList());
            e.Items.Clear();
            foreach (var item in items)
            {
                e.Items.Add(LanguageService.Translate(item));
            }            
            
        }

        public static void Translate(this DataGridView e)
        {
            var columnas = (e.DataSource as DataTable).Columns;
            foreach (DataColumn columna in columnas)
            {
                columna.ColumnName = LanguageService.Translate(columna.ColumnName);
            }
        }

    }
}
