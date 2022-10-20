using System.Data;
using System.Diagnostics.Tracing;

namespace DAL.Patente
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
                throw ex;
			}
		}
	}
}
