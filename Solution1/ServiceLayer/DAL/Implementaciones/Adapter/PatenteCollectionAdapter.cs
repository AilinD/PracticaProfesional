using Domain.PatenteFamilia;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Implementaciones.Adapter
{
    internal class PatenteCollectionAdapter
    {
		private DataTable datosDT;

		public PatenteCollectionAdapter(DataTable datosDT)
		{
			this.datosDT = datosDT;
		}

		public void Fill(List<Patente> collection)
		{
			foreach (DataRow row in datosDT.Rows)
			{
				Patente _object = new Patente();
				DataAccess.PatenteFamilia.PatenteAdapter adapter = new DataAccess.PatenteFamilia.PatenteAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
