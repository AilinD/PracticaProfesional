using Services.DAL;
using System.Data;
using System.Diagnostics.Tracing;

namespace Services.DAL.PatenteDAL
{
	public class Patente_Facade
	{
		public static List<Domain.Patente> GetAllAdapted()
		{
			try
			{
				PatenteCollectionAdapter adapter = new PatenteCollectionAdapter(SelectAll());
				List<Domain.Patente> collection = new List<Domain.Patente>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex)
			{
                throw ex;
			}
		}

		public static Domain.Patente GetAdapted(System.String IdFamiliaElement)
		{
			try
			{
				DataRow dr = Select(IdFamiliaElement);

				PatenteAdapter adapter = new PatenteAdapter(dr);

                //Instancio un objeto patente
                Domain.Patente _object = new Domain.Patente();

				adapter.Fill(_object);

				return _object;
			}
			catch (Exception ex)
			{
                throw ex;
			}
		}

		public static void Insert(Domain.Patente _object)
		{
			try
			{
				Patente_dal.Insert(_object);
			}
			catch (Exception ex)
			{
                throw ex;
			}
		}

		public static void Update(Domain.Patente _object)
		{
			try
			{
				Patente_dal.Update(_object);
			}
			catch (Exception ex)
			{
                throw ex;
			}
		}

		public static void Delete(Domain.Patente _object)
		{
			try
			{
				Patente_dal.Delete(_object);
			}
			catch (Exception ex)
			{
                throw ex;
			}
		}

		public static DataRow Select(System.String IdFamiliaElement)
		{
			try
			{
				return Patente_dal.Select(IdFamiliaElement).Tables[0].Rows[0];
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static DataTable SelectAll()
		{
			try
			{
				return Patente_dal.SelectAll().Tables[0];
			}
			catch (Exception ex)
			{
                throw ex;
			}
		}
	}
}
