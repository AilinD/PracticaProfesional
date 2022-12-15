using Services.BLL;
using System.Data;
using System.Diagnostics.Tracing;

namespace Services.DAL.PatenteDAL
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
                LoggerBLL.WriteLog("Select Familia_Patente_Facade Fallo", EventLevel.Error, "");

                return null;
            }
		}
	}
}
