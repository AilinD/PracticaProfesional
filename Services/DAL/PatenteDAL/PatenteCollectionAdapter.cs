using Services.Domain;
using System.Data;

namespace Services.DAL.PatenteDAL
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
