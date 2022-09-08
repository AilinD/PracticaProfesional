using Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.PatenteFamilia
{
	public class Patente_Facade
	{
		public static List<Patente> GetAllAdapted()
		{
			try
			{
				PatenteCollectionAdapter adapter = new PatenteCollectionAdapter(SelectAll());
				List<Patente> collection = new List<Patente>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Patente GetAdapted(System.String IdFamiliaElement)
		{
			try
			{
				DataRow dr = Select(IdFamiliaElement);

				PatenteAdapter adapter = new PatenteAdapter(dr);

				//Instancio un objeto patente
				Patente _object = new Patente();

				adapter.Fill(_object);

				return _object;
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Patente _object)
		{
			try
			{
				Patente_dal.Insert(_object);
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Patente _object)
		{
			try
			{
				Patente_dal.Update(_object);
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Patente _object)
		{
			try
			{
				Patente_dal.Delete(_object);
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
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
				//GestorErrores.Execute(ex);
				throw;
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
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
