using DataAccess.PatenteFamilia;
using Domain.PatenteFamilia;
using System;
using System.Data;

namespace DataAccess.Adapter
{

    public class FamiliaAdapter
	{
		private DataRow row;

		public FamiliaAdapter(DataRow row)
		{
			this.row = row;
		}

		public void Fill(Familia _object)
		{
			_object.IdFamiliaElement = (System.String)row["IdFamilia"];

			_object.Nombre = (System.String)row["Nombre"];

			//Traigo accesos de familia
			DataTable relacionesFamilia = DataAccess.PatenteFamilia.Familia_Patente.GetAccesos(_object.IdFamiliaElement);

			foreach (DataRow rowAccesos in relacionesFamilia.Rows)
			{
				_object.Add(Familia_Facade.GetAdapted((System.String)rowAccesos["IdFamiliaHijo"]));
			}

			//Traigo accesos de patentes
			DataTable relacionesPatentes = DataAccess.PatenteFamilia.Familia_Patente.GetAccesos(_object.IdFamiliaElement);

			foreach (DataRow rowAccesos in relacionesPatentes.Rows)
			{
				_object.Add(DataAccess.PatenteFamilia.Patente_Facade.GetAdapted((System.String)rowAccesos["IdPatente"]));
			}
		}
	}
}
