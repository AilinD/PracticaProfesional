using ServiceLayer.DAL.PatenteFamilia;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Adapter
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
				PatenteAdapter adapter = new PatenteAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
