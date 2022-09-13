using DataAccess.Adapter;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.Adapter
{
    public class FamiliaCollectionAdapter
    {
		private DataTable datosDT;

		public FamiliaCollectionAdapter(DataTable datosDT)
		{
			this.datosDT = datosDT;
		}

		public void Fill(List<Familia> collection)
		{
			foreach (DataRow row in datosDT.Rows)
			{
				Familia _object = new Familia();
				FamiliaAdapter adapter = new FamiliaAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
