using ServiceLayer.DAL.Implementaciones.Adapter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.PatenteFamilia;
using DataAccess.Adapter;

namespace ServiceLayer.DAL.PatenteFamilia
{
	public class Familia_Facade
	{
		public static List<Familia> GetAllAdapted()
		{
			try
			{
				ServiceLayer.DAL.Implementaciones.Adapter.FamiliaCollectionAdapter adapter = new ServiceLayer.DAL.Implementaciones.Adapter.FamiliaCollectionAdapter(SelectAll());
				List<Familia> collection = new List<Familia>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static Familia GetAdapted(System.String IdFamiliaElement)
		{
			try
			{
				FamiliaAdapter adapter = new FamiliaAdapter(Select(IdFamiliaElement));
				Familia _object = new Familia();
				adapter.Fill(_object);
				return _object;
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Insert(Familia _object)
		{
			try
			{
				Familia_dal.Insert(_object);
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Update(Familia _object)
		{
			try
			{
				Familia_dal.Update(_object);
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void Delete(Familia _object)
		{
			try
			{
				Familia_dal.Delete(_object);
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
				return Familia_dal.Select(IdFamiliaElement).Tables[0].Rows[0];
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
				return Familia_dal.SelectAll().Tables[0];
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}

		public static void DeleteAccesos(Familia _object)
		{
			try
			{
				Familia_dal.DeleteAccesos(_object);
			}
			catch (Exception ex)
			{
				//GestorErrores.Execute(ex);
				throw;
			}
		}
	}
}
