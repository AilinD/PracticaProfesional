
using ServiceLayer.DAL.PatenteFamilia;
using ServiceLayer.Domain.PatenteFamilia;
//using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{

	public class FamiliaAdapter
	{
		private DataRow row;

		public FamiliaAdapter(DataRow row)
		{
			this.row = row;
		}

		public void Fill(ServiceLayer.Domain.PatenteFamilia.Familia _object)
		{
			_object.IdFamiliaElement = (System.String)row["IdFamilia"];

			_object.Nombre = (System.String)row["Nombre"];

			//Traigo accesos de familia
			DataTable relacionesFamilia = Familia_dal.GetAccesos(_object.IdFamiliaElement);

			foreach (DataRow rowAccesos in relacionesFamilia.Rows)
			{
				_object.Add(Familia_Facade.GetAdapted((System.String)rowAccesos["IdFamiliaHijo"]));
			}

			//Traigo accesos de patentes
			DataTable relacionesPatentes = Familia_Patente.GetAccesos(_object.IdFamiliaElement);

			foreach (DataRow rowAccesos in relacionesPatentes.Rows)
			{
				_object.Add(Patente_Facade.GetAdapted((System.String)rowAccesos["IdPatente"]));
			}
		}
	}
}
