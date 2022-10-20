using Domain;
using System.Data;

namespace ServiceLayer.DAL.Adapter
{
	public class UsuarioCollectionAdapter
	{
		private System.Data.DataTable datosDT;

		public UsuarioCollectionAdapter(DataTable datosDT)
		{
			this.datosDT = datosDT;
		}

		public void Fill(List<Usuario> collection)
		{
			foreach (DataRow row in datosDT.Rows)
			{
				Usuario _object = new Usuario();
				UsuarioAdapter adapter = new UsuarioAdapter(row);
				adapter.Fill(_object);
				collection.Add(_object);
			}
		}
	}
}
