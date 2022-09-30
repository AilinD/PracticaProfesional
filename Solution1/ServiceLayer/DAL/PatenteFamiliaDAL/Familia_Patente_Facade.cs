using Serilog;
using ServiceLayer.Servicios.Log;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.PatenteFamilia
{
    internal class Familia_Patente_Facade
    {
		public static DataRow Select(System.String IdFamiliaElement)
		{
			try
			{
				return Familia_Patente.Select(IdFamiliaElement).Tables[0].Rows[0];
			}
			catch (Exception ex)
			{
                LoggerService.WriteLog(ex.Message,EventLevel.Error,"");
                throw ex;
			}
		}
	}
}
